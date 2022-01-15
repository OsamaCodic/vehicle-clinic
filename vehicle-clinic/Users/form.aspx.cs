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
                    ///Page load working here
                
                 



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