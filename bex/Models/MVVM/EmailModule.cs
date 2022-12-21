//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace bex.Models.MVVM
//{
//    public class EmailModule
//    {
//        public enum EmailTemplate : int
//        {
//            NewRegistration = 1,
//            PasswordReset = 2,
//            SubAttributeEmails = 3
//        }
//        private static readonly ILog Log = LogManager.GetLogger(typeof(EmailModule));
//        Modelx _db = new Modelx();
//        public bool ComposeEmail(string TemplateId, string strToAddress, string strName, string strFullName, string strPassword)
//        {
//            try
//            {
//                Log.Info("  " + "  Start Composing Email");
//                bool sendComplete = false;
//                //var temId = (EmailTemplate)Enum.ToObject(typeof(EmailTemplate), TemplateId);
//                var temId = (int)(EmailTemplate)Enum.Parse(typeof(EmailTemplate), TemplateId);
//                // var t = from s in _db.tbl_EmailTemplate where s.Id == 1 select s;
//                var dsEmailContent = _db.tbl_EmailTemplate.Where(x => x.Id == temId).FirstOrDefault();

//                var myJsonString = JsonConvert.SerializeObject(dsEmailContent, Formatting.None,
//                        new JsonSerializerSettings()
//                        {
//                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
//                        });

//                // var myJsonString = JsonConvert.SerializeObject(dsEmailContent);
//                var order_obj = JObject.Parse(myJsonString);
//                var strSubject = order_obj["TemplateSubject"].ToString();
//                var strHeader = order_obj["TemplateHeader"].ToString();
//                var strBody = order_obj["TemplateBody"].ToString();
//                var strFooter = order_obj["TemplateFooter"].ToString();

//                string contentId = "image1";
//                string path = System.Web.HttpContext.Current.Server.MapPath(@"~/PortalTheme/assets/images/AlfalahLogo.jpg");
//                LinkedResource logo = new LinkedResource(path);
//                logo.ContentId = "companylogo";



//                StringBuilder sbHeader = new StringBuilder(strHeader);
//                sbHeader.Replace("<img alt='logo' height='134' src='~/PortalTheme/assets/images/AlfalahLogo.jpg' width='180px'>",
//                    "<img alt='logo' height='134' src='cid:companylogo' width='180px'>");
//                sbHeader.ToString();

//                StringBuilder sb = new StringBuilder(strBody);
//                sb.Replace("[Name]", strFullName);
//                sb.Replace("[Password]", strPassword);
//                sb.Replace("[UserName]", strName);
//                sb.ToString();

//                StringBuilder completeMail = new StringBuilder();
//                completeMail.Append(sbHeader);
//                completeMail.Append(sb.ToString());
//                completeMail.Append(strFooter);
//                Convert.ToString(completeMail.ToString());
//                AlternateView av1 = AlternateView.CreateAlternateViewFromString(completeMail.ToString(), null, MediaTypeNames.Text.Html);
//                av1.LinkedResources.Add(logo);
//                MailMessage emailbody = new MailMessage();
//                emailbody.AlternateViews.Add(av1);
//                var body = completeMail.ToString();
//                Tbl_EmailSenderConfig SetEmail = new Tbl_EmailSenderConfig();
//                SetEmail.TempId = temId;
//                SetEmail.ToEmail = strToAddress;
//                SetEmail.EmailBody = completeMail.ToString();
//                SetEmail.EmailSubject = strSubject;
//                SetEmail.CreatedOn = DateTime.Now;
//                _db.Tbl_EmailSenderConfig.Add(SetEmail);
//                _db.SaveChanges();
//                // sendComplete = SendEmail(strToAddress, strSubject, sb.ToString(), temId);
//                return true;
//            }
//            catch (Exception ex)
//            {
//                Log.Error("  " + "  Exception occur while composing Email");
//                Log.Error("  " + ex.Message);
//                Log.Error("  " + ex.StackTrace);
//                throw;
//            }
//        }
//        public bool SendEmail(string strTo, string strSubject, string strBody, int temId)
//        {
//            Modelx db = new Modelx();
//            string strFrom = ConfigurationManager.AppSettings["SenderEmail"];
//            string Password = ConfigurationManager.AppSettings["Password"];
//            string strHosst = ConfigurationManager.AppSettings["Host"];
//            int strPort = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
//            bool BolWebMehtod = false;
//            Log.Info("  " + "  Sending Email");

//            //insert logs
//            using (var dbContextTransaction = db.Database.BeginTransaction())
//            {
//                tbl_EmailLogs logs = new tbl_EmailLogs();
//                logs.TempId = temId;
//                logs.ToEmail = strTo;
//                logs.EmailSubject = strSubject;
//                logs.EmailBody = strBody;
//                logs.CreatedOn = DateTime.Now;
//                //logs.SendBy = 1;
//                db.tbl_EmailLogs.Add(logs);
//                db.SaveChanges();
//                dbContextTransaction.Commit();
//                //  AddEmaiLog(strFrom, strTo, strSubject, strBody, "SendEmailWithBCC");
//                try
//                {
//                    using (var message = new MailMessage())
//                    {
//                        string[] Recipents = strTo.Split(',');
//                        foreach (var item in Recipents)
//                        {
//                            message.To.Add(new MailAddress(item));
//                        }
//                        //message.To.Add(new MailAddress(strTo));
//                        message.From = new MailAddress(strFrom);
//                        // message.CC.Add(new MailAddress("cc@email.com", "CC Name"));
//                        //message.Bcc.Add(new MailAddress("d4done.dev@gmail.com"));
//                        message.Subject = strSubject;
//                        message.Body = strBody;
//                        message.IsBodyHtml = true;
//                        using (var client = new SmtpClient(strHosst))
//                        {
//                            client.Port = strPort;
//                            client.UseDefaultCredentials = false;
//                            client.Credentials = new NetworkCredential(strFrom, Password);
//                            client.EnableSsl = true;

//                            client.Send(message);
//                        }
//                        return true;
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Log.Error("  " + "  Exception occur while sending Email");
//                    Log.Error("  " + ex.Message);
//                    Log.Error("  " + ex.StackTrace);
//                    dbContextTransaction.Rollback();
//                    return false;
//                }
//            }

//        }
//    }
//}
