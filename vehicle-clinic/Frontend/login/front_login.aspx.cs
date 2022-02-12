using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend.login
{
    public partial class front_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "VehicleClinic | Login";
        }

        protected void front_loginForm_Btn_Click(object sender, EventArgs e)
        {

            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                if (DB.users.Where(r => r.email == email_value.Text && r.password == password_value.Text && r.role == 2).Count() == 1)
                {
                    user obj = DB.users.FirstOrDefault(c => c.email == email_value.Text && c.role == 2); //Role: User

                    int logged_userID = Convert.ToInt32(obj.user_id);
                    Session["front_logged_userID"] = logged_userID;

                    HttpCookie cookie = new HttpCookie("front_LoggedUser");
                    cookie["front_userID"] = Session["front_logged_userID"].ToString();

                    cookie.Expires = DateTime.Now.AddHours(12);
                    Response.Cookies.Add(cookie);

                    Response.Redirect("../products/index.aspx");
                }
                else
                {
                    error_message.InnerText = "Wrong login credentials!";
                    email_value.Text = "";
                    password_value.Text = "";
                }
            }
        }
    }
}