using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bex.Models.MVVM
{
    public class Authenticate
    {
        public class Users_Tuple
        {
            public int ID { get; set; }

            [DisplayName("User Name")]
            [Required(ErrorMessage = "This Field is required")]
            public string LoginName { get; set; }
            [DataType(DataType.Password)]

            [Required(ErrorMessage = "This Field is required")]
            public string Password { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public Nullable<System.DateTime> CreatedDate { get; set; }
            public Nullable<System.DateTime> PasswordChanged { get; set; }
            public Nullable<bool> isActive { get; set; }
            public Nullable<int> CreatedBy { get; set; }
            public Nullable<int> ModifiedBy { get; set; }
            public Nullable<System.DateTime> ModifiedOn { get; set; }

            public string Errormsg { get; set; }
        }

        public class EditUser
        {
            [Required]
            public int ID { get; set; }

            [Required]
            public string LoginName { get; set; }
            [Required]
            public string Password { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public Nullable<System.DateTime> PasswordChanged { get; set; }
            [Required]
            public string FullName { get; set; }
            [Required]
            public string Email { get; set; }

            public Nullable<System.DateTime> CreatedDate { get; set; }

            public Nullable<bool> isActive { get; set; }

            public Nullable<int> CreatedBy { get; set; }

            public Nullable<int> ModifiedBy { get; set; }

            public Nullable<System.DateTime> ModifiedOn { get; set; }
        }
        public class UpdatePasswordModel
        {
            [Required]
            public int ID { get; set; }


            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Current password")]
            public string Password { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }


        }
        public class CreateUser
        {
            public long Id { get; set; }

            [DisplayName("User Name")]
            public string UserName { get; set; }
            [DataType(DataType.Password)]

            [Required(ErrorMessage = "This Field is required")]
            public string Password { get; set; }

            [DisplayName("Full Name")]
            [Required(ErrorMessage = "This Field is required")]
            public string FullName { get; set; }

            [DisplayName("Email")]
            [Required(ErrorMessage = "This Field is required")]
            [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]


            public string Email { get; set; }
            public long RoleId { get; set; }
            public bool IsActive { get; set; }
            public bool IsApproved { get; set; }
            public int BranchId { get; set; }
            public int AreaId { get; set; }
            public int RegionId { get; set; }
            public string ischeck { get; set; }
            public string isPortalLogin { get; set; }
            public int DesignationId { get; set; }
            public Nullable<int> InputterType { get; set; }
        }

        public CommonHelper.result Create(CreateUser Data, int Userid)
        {
            CommonHelper.result Objresult = new CommonHelper.result();
            string Message = "";
            bool status = true;
            bool emailSuccess = false;
            using (var db = new Modelx())
            {

                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    var check = (from checUsers in db.TblUsers
                                 where checUsers.UserName == Data.UserName && checUsers.IsActive == true && checUsers.IsDeleted == false
                                 select new
                                 {
                                     checUsers.UserName
                                 });
                    var email = db.TblUsers.Where(x => x.Email.ToLower().Trim() == Data.Email.ToLower().Trim() && x.IsActive == true && x.IsDeleted == false).FirstOrDefault();
                    var res = check.FirstOrDefault(x => x.UserName.ToLower() == Data.UserName.ToLower());
                    if (res == null && email == null)
                    {
                        try
                        {
                            //EmailModule mail = new EmailModule();
                            var Enc_password = Login.Encrypt(Data.Password);
                            //    db.SP_CreateUser(Data.LoginName, Enc_password, Data.FullName, Data.Email, Userid);

                            TblUser newUser = new TblUser();
                            newUser.RoleId = Convert.ToInt32(Data.RoleId);
                            newUser.FullName = Data.FullName;
                            newUser.UserName = Data.UserName;
                            newUser.Email = Data.Email;
                            newUser.Password = Enc_password;
                            newUser.CreatedOn = DateTime.UtcNow;
                            newUser.CreatedBy = Userid;

                            if (Convert.ToInt32(Data.RoleId) != 3)
                            {
                                newUser.IsPortalLogin = "yes";
                            }
                            else
                            {
                                newUser.IsPortalLogin = Data.isPortalLogin;
                            }
                            newUser.InputterType = Data.InputterType;
                            newUser.IsDeleted = false;
                            newUser.IsActive = true;
                            newUser.IsLock = false;
                            var user = db.TblUsers.Add(newUser);
                            db.SaveChanges();
                            TblUserPasswordHistory passhistory = new TblUserPasswordHistory();
                            passhistory.IsActive = true;
                            passhistory.Password = Enc_password;
                            passhistory.UserId = newUser.Id;
                            passhistory.CreatedDate = DateTime.Now;
                            passhistory.UserName = Data.UserName;
                            db.TblUserPasswordHistories.Add(passhistory);
                            db.SaveChanges();
                            if (newUser.RoleId == 3)
                            {
                                MobileAppRegistration mbl = new MobileAppRegistration()
                                {
                                    AreaId = Data.AreaId,
                                    BranchId = Data.BranchId,
                                    CreatedDate = DateTime.Now,
                                    DesignationId = Data.DesignationId,
                                    DeviceId = "device",
                                    EmailSentApp = false,
                                    EmailSentRegApp = false,
                                    IsActive = true, //Data.IsActive,
                                    IsApproved = Data.IsApproved,
                                    Ischeck = Data.ischeck,
                                    RegionId = Data.RegionId,
                                    UserId = newUser.Id,
                                    UserName = newUser.UserName,
                                    UserTypeId = newUser.InputterType.HasValue ? newUser.InputterType.Value : 0
                                };
                                db.MobileAppRegistrations.Add(mbl);
                                db.SaveChanges();
                            }
                            if ((!Data.IsApproved && Data.RoleId != 3) || (Data.IsApproved && Data.RoleId == 3) || (Data.IsApproved && Data.RoleId != 3))
                            {  //Email Sending removed on suggestion of saif bhai.
                               //emailSuccess = mail.ComposeEmail("NewRegistration", Data.Email, Data.UserName, Data.FullName, Data.Password);
                            }
                            Message = "User Added SuccessFully";
                            dbContextTransaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            status = false;
                            Message = ex.Message;
                            dbContextTransaction.Rollback();
                        }
                    }
                    else
                    {
                        status = false;
                        if (email != null)
                        { Message = "User Already Exists with this email address'" + Data.Email + "'"; }
                        else { Message = "User Already Exists with this User Name '" + Data.UserName + "'"; }
                    }
                }

                Objresult.message = Message;
                Objresult.Status = status;
                return Objresult;
            }

        }

        public CommonHelper.result UpdateUser(CreateUser Data, int loginId, string Userid, string password)
        {
            CommonHelper.result Objresult = new CommonHelper.result();
            string Message;
            bool status = true;
        //    EmailModule mail = new EmailModule();
            bool emailSuccess = true;
            bool NewInputter = false;
            using (var db = new Modelx())
            {

                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    int temp = 0;
                    var email = db.TblUsers.Where(x => x.Email.ToLower().Trim() == Data.Email.ToLower().Trim() && x.IsActive == true && x.IsDeleted == false).ToList();
                    var email1 = db.TblUsers.Where(x => x.Id == Data.Id && x.Email.ToLower().Trim() == Data.Email.ToLower().Trim() && x.IsActive == true && x.IsDeleted == false).FirstOrDefault();

                    var res = db.TblUsers.Where(x => x.UserName.ToLower() == Data.UserName.ToLower()).ToList();

                    for (int i = 0; i < email.Count; i++)
                    {
                        temp++;

                    }

                    if (temp == 1 && email1 == null)
                    {
                        temp = 2;

                    }

                    if (temp < 2)
                    {



                        try
                        {
                            var Enc_Password = Login.Encrypt(password);
                            if (Data.IsApproved)
                            {
                                TblUserPasswordHistory objPasswordHistory = new TblUserPasswordHistory();
                                var updatePasswordHistoryNew = db.TblUserPasswordHistories.Where(x => x.UserId == Data.Id && x.IsActive == true).FirstOrDefault();
                                updatePasswordHistoryNew.IsActive = false;
                                db.SaveChanges();
                                objPasswordHistory.UserId = Data.Id;
                                objPasswordHistory.UserName = Data.UserName;
                                objPasswordHistory.Password = Enc_Password;
                                objPasswordHistory.ModifiedDate = DateTime.UtcNow;
                                objPasswordHistory.IsActive = true;
                                db.TblUserPasswordHistories.Add(objPasswordHistory);
                            }
                            //  TblUsers updateuser = db.TblUsers.Where(x => x.UserName == Data.UserName).FirstOrDefault();
                            TblUser updateuser = db.TblUsers.Where(x => x.Id == Data.Id).FirstOrDefault();
                            MobileAppRegistration mAppReg = db.MobileAppRegistrations.Where(x => x.UserName == Data.UserName).FirstOrDefault();
                            updateuser.UserName = Data.UserName;
                            updateuser.FullName = Data.FullName;
                            if (updateuser.RoleId == 3 && Data.RoleId != 3)
                            {
                                mAppReg.IsActive = false;
                                mAppReg.UserTypeId = 0;
                                updateuser.InputterType = null;
                                //new
                                mAppReg.BranchId = Data.BranchId;
                                mAppReg.DesignationId = Data.DesignationId;
                                mAppReg.RegionId = Data.RegionId;
                                mAppReg.AreaId = Data.AreaId;
                                mAppReg.IsApproved = Data.IsApproved;
                                mAppReg.Ischeck = Data.ischeck;
                            }
                            if (Convert.ToInt32(Data.RoleId) != 3)
                            {
                                updateuser.IsPortalLogin = "yes";
                            }
                            else
                            {
                                updateuser.IsPortalLogin = Data.isPortalLogin;
                            }
                            updateuser.RoleId = Convert.ToInt32(Data.RoleId);
                            updateuser.Email = Data.Email;
                            updateuser.IsActive = true;// Data.IsActive;
                            updateuser.InputterType = Data.InputterType;
                            updateuser.ModifiedOn = Convert.ToDateTime(DateTime.Now.ToString());
                            updateuser.ModifiedBy = Convert.ToInt32(loginId);
                            if (Data.IsApproved)
                                updateuser.Password = Enc_Password;
                            if (Data.RoleId == 3)
                            {
                                if (mAppReg != null)
                                {
                                    mAppReg.AreaId = Data.AreaId;
                                    mAppReg.BranchId = Data.BranchId;
                                    mAppReg.DesignationId = Data.DesignationId;
                                    mAppReg.DeviceId = "device";
                                    mAppReg.EmailSentApp = false;
                                    mAppReg.EmailSentRegApp = false;
                                    mAppReg.IsActive = true;//Data.IsActive;
                                    mAppReg.IsApproved = Data.IsApproved;
                                    mAppReg.RegionId = Data.RegionId;
                                    mAppReg.UserId = updateuser.Id;
                                    mAppReg.Ischeck = Data.ischeck;
                                    mAppReg.UserName = updateuser.UserName;
                                    mAppReg.UserTypeId = updateuser.InputterType.HasValue ? updateuser.InputterType.Value : 0;
                                    mAppReg.ModifiedBy = loginId;
                                    mAppReg.ModifiedDate = DateTime.Now;
                                }
                                else
                                {
                                    MobileAppRegistration ObjMobileAppRegistration = new MobileAppRegistration();
                                    ObjMobileAppRegistration.AreaId = Data.AreaId;
                                    ObjMobileAppRegistration.BranchId = Data.BranchId;
                                    ObjMobileAppRegistration.DesignationId = Data.DesignationId;
                                    ObjMobileAppRegistration.DeviceId = "device";
                                    ObjMobileAppRegistration.EmailSentApp = false;
                                    ObjMobileAppRegistration.EmailSentRegApp = false;
                                    ObjMobileAppRegistration.IsActive = true; // Data.IsActive;
                                    ObjMobileAppRegistration.IsApproved = Data.IsApproved;
                                    ObjMobileAppRegistration.Ischeck = Data.ischeck;
                                    ObjMobileAppRegistration.RegionId = Data.RegionId;
                                    ObjMobileAppRegistration.UserId = updateuser.Id;
                                    ObjMobileAppRegistration.UserName = updateuser.UserName;
                                    ObjMobileAppRegistration.UserTypeId = updateuser.InputterType.HasValue ? updateuser.InputterType.Value : 0;
                                    ObjMobileAppRegistration.ModifiedBy = loginId;
                                    // ObjMobileAppRegistration.ModifiedDate = DateTime.Now;
                                    ObjMobileAppRegistration.CreatedDate = DateTime.Now;
                                    db.MobileAppRegistrations.Add(ObjMobileAppRegistration);

                                    NewInputter = true;

                                }
                            }
                          //  if ((!Data.IsApproved && Data.RoleId != 3) || (Data.IsApproved && Data.RoleId == 3) || (Data.IsApproved && Data.RoleId != 3))
                             //   emailSuccess = mail.ComposeEmail("PasswordReset", Data.Email, Data.UserName, Data.FullName, password);
                            db.SaveChanges();
                            Message = "User Updated SuccessFully";
                            dbContextTransaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            status = false;
                            Message = ex.Message;
                            dbContextTransaction.Rollback();
                        }
                    }

                    else
                    {
                        status = false;
                        if (email != null)
                        { Message = "User Already Exists with this email address'" + Data.Email + "'"; }
                        else { Message = "User Already Exists with this User Name '" + Data.UserName + "'"; }
                    }


                }
                Objresult.Status = status;
                Objresult.message = Message;
                return Objresult;
            }
        }
        /// <summary>
        /// Added By Ahsan 2-June-2021
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="Userid"></param>
        /// <returns></returns>
        //public CommonHelper.result ApproveUser(int loginId, string Userid)
        //{
        //    ILog Log = LogManager.GetLogger(typeof(Authenticate));
        //    EmailSender email = new EmailSender();
        //    CommonHelper.result Objresult = new CommonHelper.result();
        //    string Message;
        //    bool status = true;
        //    bool EmailResult = true;
        //    using (var db = new Modelx())
        //    {
        //        using (var dbContextTransaction = db.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                TblUser updateuser = db..Where(x => x.UserName == Userid).FirstOrDefault();
        //                MobileAppRegistration mAppReg = db.MobileAppRegistrations.Where(x => x.UserName == Userid).FirstOrDefault();
        //                MobileAppRegistration mAppRegs = db.MobileAppRegistrations.Where(x => x.UserID == updateuser.ID).FirstOrDefault();
        //                //EmailModule

        //                if (updateuser != null)
        //                {
        //                    updateuser.IsActive = true;
        //                    updateuser.ModifiedOn = Convert.ToDateTime(DateTime.Now.ToString());
        //                    updateuser.ModifiedBy = Convert.ToInt32(loginId);
        //                    db.SaveChanges();
        //                    Message = "User Approved SuccessFully";
        //                    // EmailResult = email.ComposeEmail(13, updateuser.UserName, updateuser.Email);
        //                }
        //                else
        //                {
        //                    Message = "User Approval Failed";
        //                }

        //                if (mAppReg != null)
        //                {
        //                    mAppReg.IsActive = true;
        //                    mAppReg.IsApproved = true;
        //                    mAppReg.ModifiedBy = loginId;
        //                    mAppReg.ModifiedDate = DateTime.Now;
        //                    db.SaveChanges();
        //                    Message = "User Approved SuccessFully";
        //                }
        //                else
        //                {
        //                    Message = "User Approval Failed";
        //                }
        //                dbContextTransaction.Commit();
        //            }
        //            catch (Exception ex)
        //            {
        //                status = false;
        //                Message = ex.Message;
        //                Log.Error(ex.Message);
        //                //if (EmailResult == false)
        //                //{
        //                //    dbContextTransaction.Commit();
        //                //}
        //                //else
        //                //{

        //                //    dbContextTransaction.Rollback();
        //                //}
        //            }
        //        }
        //        Objresult.Status = status;
        //        return Objresult;
        //    }
        //}

        //public List<TblUsers> GetAllUser()
        //{
        //    using (var db = new Modelx())
        //    {
        //        try
        //        {
        //            return db.Database.SqlQuery<TblUsers>("Sp_GetAllUsers").ToList();
        //        }
        //        catch (Exception e)
        //        {

        //        }
        //        return null;
        //    }
        //}
        public CommonHelper.result DeleteUSer(int Id)
        {
            CommonHelper.result Objresult = new CommonHelper.result();
            string Message;
            bool status = true;



            using (var db = new Modelx())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        //TblUsers deleteUser = db.TblUsers.Where(x => x.ID == Id).FirstOrDefault();
                        TblUser deleteUser = db.TblUsers.Where(x => x.Id == Id).FirstOrDefault();
                        deleteUser.IsActive = false;
                        db.SaveChanges();
                        Message = "User Deleted!";
                        dbContextTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        status = false;
                        Message = e.Message;
                        dbContextTransaction.Rollback();
                    }
                }
                Objresult.message = Message;
                Objresult.Status = status;
                return Objresult;
            }



        }
        public CommonHelper.result DeleteUSer(string Id)
        {
            CommonHelper.result Objresult = new CommonHelper.result();
            string Message;
            bool status = true;



            using (var db = new Modelx())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        //TblUsers deleteUser = db.TblUsers.Where(x => x.ID == Id).FirstOrDefault();
                        //  TblUsers deleteUser = db.TblUsers.Where(x => x.UserName == Id).FirstOrDefault();
                        var deleteUser = db.TblUsers.Where(x => x.UserName == Id && x.IsActive == true).ToList();
                        MobileAppRegistration MobileUser = db.MobileAppRegistrations.Where(x => x.UserName == Id).FirstOrDefault();

                        //if(deleteUser != null)
                        //{
                        //    deleteUser.IsActive = false;
                        //    deleteUser.IsDeleted = true;
                        //}

                        if (deleteUser.Count > 0)
                        {
                            foreach (var i in deleteUser)
                            {
                                i.IsActive = false;
                                i.IsDeleted = true;
                            }
                        }

                        if (MobileUser != null)
                        {
                            db.MobileAppRegistrations.Remove(MobileUser);
                            db.SaveChanges();

                            //MobileUser.IsActive = false;
                            //MobileUser.IsApproved = false;
                        }

                        db.SaveChanges();
                        Message = "User Deleted!";
                        dbContextTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        status = false;
                        Message = e.Message;
                        dbContextTransaction.Rollback();
                    }
                }
                Objresult.message = Message;
                Objresult.Status = status;
                return Objresult;
            }



        }
        //public CommonHelper.result Update(Authenticate.CreateUser Model, int Userid)
        //{
        //    CommonHelper.result Objresult = new CommonHelper.result();
        //    string Message;
        //    bool status = true;
        //    using (var db = new Modelx())
        //    {

        //        using (var dbContextTransaction = db.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                TblUsers Update = db.TblUsers.Where(x => x.ID == Model.Id).FirstOrDefault();
        //                Update.UserName = Model.UserName;
        //                Update.FullName = Model.FullName;
        //                var Enc_Password = Login.Encrypt(Model.Password);
        //                Update.Password = Enc_Password;
        //                //Update.PasswordChanged = Data.PasswordChanged;
        //                Update.ModifiedBy = Userid;
        //                db.SaveChanges();
        //                Message = "Campaigng Updated!";
        //                dbContextTransaction.Commit();

        //            }
        //            catch (Exception ex)
        //            {
        //                status = false;
        //                Message = ex.Message;
        //                dbContextTransaction.Rollback();
        //            }
        //        }

        //        Objresult.message = Message;
        //        Objresult.Status = status;
        //        return Objresult;
        //    }

        //}

        //public CommonHelper.result UpdatePassword(UpdatePasswordModel Data, int Userid)
        //{
        //    CommonHelper.result Objresult = new CommonHelper.result();
        //    string Message = "";
        //    bool status = true;
        //    using (var db = new Modelx())
        //    {

        //        using (var dbContextTransaction = db.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var Enc_Password = Login.Encrypt(Data.Password);
        //                var checkOldPasswd = db.TblUsers.FirstOrDefault(x => x.Password == Enc_Password);
        //                if (checkOldPasswd != null)
        //                {
        //                    if (Data.NewPassword == Data.ConfirmPassword)
        //                    {
        //                        var Enc_NewPassword = Login.Encrypt(Data.NewPassword);
        //                        TblUsers Update = db.TblUsers.Where(x => x.ID == Userid).FirstOrDefault();
        //                        Update.Password = Enc_NewPassword;

        //                        db.SaveChanges();
        //                        Message = "SuccessFull";
        //                        dbContextTransaction.Commit();
        //                    }
        //                    else
        //                    {
        //                        status = false;
        //                        dbContextTransaction.Rollback();
        //                        Objresult.message = "Password not match";
        //                    }
        //                }
        //                else
        //                {
        //                    status = false;
        //                    dbContextTransaction.Rollback();
        //                    Objresult.message = "Something went wrong";
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                status = false;
        //                Message = ex.Message;
        //                dbContextTransaction.Rollback();
        //            }
        //        }

        //        Objresult.message = Message;
        //        Objresult.Status = status;
        //        return Objresult;
        //    }

        //}

    }
    public class Login
    {
        private static string Key = "M3techCMSDemo";
        public static string Encrypt(string plainText)
        {
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            var res = Convert.ToBase64String(Encrypt(plainBytes, GetRijndaelManaged(Key)));
            return res;
        }
        public static byte[] Encrypt(byte[] plainBytes, RijndaelManaged rijndaelManaged)
        {
            return rijndaelManaged.CreateEncryptor().TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        }
        public static string Decrypt(string encryptedText)
        {
            var encryptedBytes = Convert.FromBase64String(encryptedText);
            return Encoding.UTF8.GetString(Decrypt(encryptedBytes, GetRijndaelManaged(Key)));
        }
        public static byte[] Decrypt(byte[] encryptedData, RijndaelManaged rijndaelManaged)
        {
            return rijndaelManaged.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
        }
        public static RijndaelManaged GetRijndaelManaged(String secretKey)
        {
            var keyBytes = new byte[16];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            Array.Copy(secretKeyBytes, keyBytes, Math.Min(keyBytes.Length, secretKeyBytes.Length));
            return new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = keyBytes
            };
        }
    }
}
