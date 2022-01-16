using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Security.Cryptography;

namespace vehicle_clinic.Users
{
    public partial class form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"] != null)
                {

                    var userID = Convert.ToInt32(Request.QueryString["user_id"]);


                    //if (userID != null)
                    //{
                    //    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    //    {
                    //        //var row = DB.users.Where(r => r.user_id == userID).FirstOrDefault();
                    //        //email_txtbox.Text = row.email; /////Object reference not set to an instance of an object.

                    //        string row = DB.getSingleUser(userID).FirstOrDefault().ToString();
                    //        email_txtbox.Text = row.first_name;
                    //    }
                    //}

                    

              



                }
            else
                {
                    Response.Redirect("../authorization/loginForm.aspx");
                }
        }
        

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                ///Email should be unique
                if (DB.users.Where(r => r.email == email_txtbox.Text).Count() > 0)
                {
                    errorMessage.Style.Add("display", "block");
                    errorMessage.InnerHtml = "The email address is already taken. Please choose another";
                }
                else
                {
                    user obj = new user();
                    obj.first_name = first_name_txtbox.Text;
                    obj.second_name = second_name_txtbox.Text;
                    obj.email = email_txtbox.Text;

                    ////Convert password into Hash
                    //string password = password_txtbox.Text;
                    //byte[] salt = new byte[128 / 8];
                    //using (var rngCsp = new RNGCryptoServiceProvider())
                    //{
                    //    rngCsp.GetNonZeroBytes(salt);
                    //}
                    //Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

                    //System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 10000);
                    //string hashed = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256 / 8));
                    ////Convert password into Hash

                    obj.password = password_txtbox.Text;
                    obj.display_order = display_order_txtbox.Text;
                    obj.role = Convert.ToInt32(roleList.SelectedValue);
                    obj.created_at = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");



                    DB.users.Add(obj);
                    DB.SaveChanges();

                    Response.Redirect("index.aspx");
                }

            }
        }
    }
}