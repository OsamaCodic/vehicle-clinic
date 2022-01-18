using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.authorization
{
    public partial class loginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginForm_Btn_Click(object sender, EventArgs e)
        {
            string email = email_value.Text;
            string password = password_value.Text;
            ///Response.Write("Email:" + email + "<br>" + "Password:" + password);
            
            vehicle_clinicEntities DB = new vehicle_clinicEntities();
            
            try
            {
                if(DB.users.Where(r=>r.email==email_value.Text && r.password== password_value.Text).Count()>0)
                {
                    Session["auth_user"] = email_value.Text;

                    HttpCookie cookie = new HttpCookie("LoginCredentials");

                    cookie.Value = email_value.Text;

                    //cookie["authUser_Email"] = email_value.Text;
                    //cookie["authUser_Password"] = password_value.Text;


                    cookie.Expires = DateTime.Now.AddSeconds(10);
                    Response.Cookies.Add(cookie);

                    Response.Redirect("../dashboard.aspx");
                }
                else
                {
                    error_message.InnerText = "Wrong login credentials!";
                    
                    ////Empty form
                    email_value.Text = "";
                    password_value.Text = "";
                }
            }
            catch
            {

            }
        }
    }
}