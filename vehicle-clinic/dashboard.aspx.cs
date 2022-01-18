using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["LoginCredentials"] != null)
            {
                //Session["auth_user"] = Request.Cookies["LoginCredentials"]["authUser_Email"];

                Session["auth_user"] = Request.Cookies["LoginCredentials"].Value;
            }

            if (Session["auth_user"] != null)
            {
                ///Page load working here


                using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                {

                    total_user_box.InnerText = "(" + DB.readUsers().Count() + ")";
                }




            }
            else
            {
                Response.Redirect("authorization/loginForm.aspx");
            }
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Session["auth_user"] != null)
            {
                Session["auth_user"] = null;
                Response.Redirect("authorization/loginForm.aspx");
                Response.Write("Thank-you you are logout!");
            }
        }
    }
}