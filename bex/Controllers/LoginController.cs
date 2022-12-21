using bex.Models;
using bex.Models.MVVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bex.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        // private static readonly ILog Log = LogManager.GetLogger(typeof(LoginController));
        public ActionResult Index()
        {
            return View();
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Authorization(Authenticate.Users_Tuple UserModel)
        {
            // remove password coment after 
            try
            {
                if (ModelState.IsValid)
                {
                    Modelx db = new Modelx();
                    var check = db.TblAppUsers.Where(x => x.UserName.ToLower() == UserModel.LoginName).FirstOrDefault();
                    //u.Name = Administrator
                    //Passowrd = original = Helloworld,  encrypted = h6KfbVIwn4nk5ig1ohUhaA==
                    //var Dec_password = Login.Decrypt("xexZWwOtHSRLkwWrinxK7w==");
                    // CDu7530m


                    // 3s606BDf
                    //615Bc2Xo
                    //15Rv11Ev new pass= 599xv1MP

                    //
                    var Enc_Password = Login.Encrypt(UserModel.Password);
                    Authenticate objAuthenticateUser = new Authenticate();
                    try
                    {
                        //added inputter type
                        if (check != null)
                        {

                            var U_Model = (from users in db.TblAppUsers
                                           where users.UserName == UserModel.LoginName
                                           //&& users.password == Enc_Password 
                                           && users.Password == UserModel.Password
                                           // &&
                                           //users.isActive == true && users.isDeleted == false
                                           select new
                                           {
                                               users.Id,
                                               users.FullName,
                                               users.UserName,
                                               users.Email,
                                               users.RoleId,
                                               users.UserType,
                                               users.IsActive,


                                           }).ToList();

                            if (U_Model != null && U_Model.Count > 0)
                            {
                                HttpContext.Session.SetString("UserName", U_Model.FirstOrDefault().UserName);
                                HttpContext.Session.SetString("FullName", U_Model.FirstOrDefault().FullName);
                                HttpContext.Session.SetString("UserID", U_Model.FirstOrDefault().Id.ToString());
                                HttpContext.Session.SetString("UserRole", U_Model.FirstOrDefault().UserType);
                                HttpContext.Session.SetString("inputterType", U_Model.FirstOrDefault().RoleId.ToString());
                                //Session["UserName"] = U_Model.FirstOrDefault().userName;
                                //Session["FullName"] = U_Model.FirstOrDefault().fullName;
                                //Session["UserID"] = U_Model.FirstOrDefault().Id;
                                //Session["UserRole"] = U_Model.FirstOrDefault().userType;
                                //Session["inputterType"] = U_Model.FirstOrDefault().roleId;





                                int inputter = Convert.ToInt32(U_Model.FirstOrDefault().RoleId);





                                int RoleId = Convert.ToInt32(U_Model.FirstOrDefault().UserType);



                                if (RoleId == 0)
                                {


                                    var RolePrevilages = (from pr in db.TblPrivileges
                                                          join pa in db.TblPages on pr.PageId equals pa.Id
                                                          where pr.RoleId == RoleId
                                                          select new RolePrivilagesModel
                                                          {
                                                              DisplayName = pa.DisplayName,
                                                              MethodName = pa.MethodName,
                                                              RoleId = RoleId,
                                                              RightToAdd = pr.RightToAdd,
                                                              RightToView = pr.RightToView,
                                                              RightToEdit = pr.RightToEdit,
                                                              RightToDelete = pr.RightToDelete
                                                          }).ToList();
                                 
                                    HttpContext.Session.SetString("RolePrevilages", JsonConvert.SerializeObject(RolePrevilages));
                                 

                                    
                                   
                                }

                                else
                                {

                                    var RolePrevilages = (from pr in db.TblPrivileges
                                                          join pa in db.TblPages on pr.PageId equals pa.Id
                                                          where pr.RoleId == inputter
                                                          select new RolePrivilagesModel
                                                          {
                                                              DisplayName = pa.DisplayName,
                                                              MethodName = pa.MethodName,
                                                              RoleId = inputter,
                                                              RightToAdd = pr.RightToAdd,
                                                              RightToView = pr.RightToView,
                                                              RightToEdit = pr.RightToEdit,
                                                              RightToDelete = pr.RightToDelete
                                                          }).ToList();
                                    HttpContext.Session.SetString("RolePrevilages", JsonConvert.SerializeObject(RolePrevilages));



                                }




                                //if (Session["UserRole"].ToString() == "3")
                                //{
                                //    UserModel.Errormsg = "Invalid Username/Password";
                                //    return View("index", UserModel);
                                //}
                                //else
                                //{
                                //    Log.Info(Session["UserName"].ToString() + "  " + "Is Successfully Logged In");
                                //    Log.Info("setup Sessions");
                                //    Log.Info("UserName" + Session["UserName"].ToString());
                                //    Log.Info("FullName" + Session["FullName"].ToString());
                                //    Log.Info("UserID" + Session["UserID"].ToString());
                                //    Log.Info("Role" + Session["UserRole"].ToString());
                                //    check.InvalidAttempths = 0;
                                //    db.SaveChanges();
                                //    return Redirect("~/Home");
                                //}
                                return Redirect("~/Home");
                            }
                            //else
                            //{
                            //    UserModel.Errormsg = "Invalid Username/Password";
                            //    if (check.InvalidAttempths == 5)
                            //    { UserModel.Errormsg = "Your account has been temporarily disabled Please contact admin."; }
                            //    if (check.InvalidAttempths != 5)
                            //    {
                            //        if (check.InvalidAttempths == null) { check.InvalidAttempths = 0; }

                            //        check.InvalidAttempths = check.InvalidAttempths + 1;
                            //        if (check.InvalidAttempths == 5)
                            //        {
                            //            check.IsLock = true;
                            //            UserModel.Errormsg = "Your account has been temporarily disabled Please contact admin.";
                            //        }
                            //        db.SaveChanges();
                            //    }
                            //}


                        }
                        return View("index", UserModel);

                    }


                    catch (Exception ex)
                    {
                        //Log.Error(Session["UserName"].ToString() + "    " + ex.Message);
                        //Log.Error(Session["UserName"].ToString() + "  " + ex.StackTrace);
                        UserModel.Errormsg = "Invalid Username/Password";
                        return View("index", UserModel);
                    }
                }
                else
                {
                    UserModel.Errormsg = "Invalid Username/Password";
                    return View("index", UserModel);
                }
            }
            catch (Exception ex)
            {
                UserModel.Errormsg = "" + ex.Message;
                return View("index", UserModel);
            }

        }
        //public ActionResult Logout()
        //{
        //    Session["UserName"] = null;
        //    Session["UserRole"] = null;
        //    Session["FullName"] = null;
        //    Session["UserID"] = null;
        //    //HttpContext.Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
        //    Response.AppendHeader("Cache-Control", "no-store");
        //    Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //    Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        //    Response.Cache.SetNoStore();
        //    Session.Clear();
        //    // Session.RemoveAll();
        //    Session.Abandon();
        //    //  Response.Cookies.Clear();
        //    Log.Info("  " + " " + "User Logout");
        //    return Redirect("~/Login/Index");
        //}


        public ActionResult DemoLogin()
        {

            return Redirect("~/Home/Index");

        }

        public ActionResult changePassword()
        {

            return View();

        }

        [HttpPost]
        public ActionResult changePassword(string oldPasswword, string newPasswword)
        {


            Modelx db = new Modelx();

            int userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));


            var list = db.TblAppUsers.Where(x => x.Id == userid && x.Password == oldPasswword).FirstOrDefault();
            //var list1 = db.Tbl_AppUser.Where(x => x.password == newPasswword).FirstOrDefault();


            if (newPasswword == "" || oldPasswword == "")
            {
                ViewBag.error = "null";
                return View();

            }
            if (list != null)
            {
                list.Password = newPasswword;
                db.SaveChanges();
                ViewBag.error = "success";
            }

            //if (list1 != null)
            //{
            //    ViewBag.error = "exist";
            //    return View();

            //}

            else
            {
                ViewBag.error = "error";
                return View();
            }




            return View();





        }
        //public class RolePrivilagesModel
        //{
        //    public string DisplayName { get; set; }
        //    public string MethodName { get; set; }
        //    public int RoleId { get; set; }
        //    public bool? RightToAdd { get; set; }
        //    public bool? RightToView { get; set; }
        //    public bool? RightToDelete { get; set; }
        //    public bool? RightToEdit { get; set; }


        //}
    }
}
