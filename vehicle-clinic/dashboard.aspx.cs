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
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["authUser_Email"];

                if (Session["auth_user"] != null)
                {
                    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    {
                        total_user_box.InnerText = "(" + DB.readUsers().Count() + ")";
                        total_categories_box.InnerText = "(" + DB.getCategories().Count() + ")";
                        total_products_box.InnerText = "(" + DB.getProducts().Count() + ")";
                    }
                }
            }
            else
            {
                Response.Redirect("authorization/loginForm.aspx");
            }
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                Response.Cookies["LoginCredentials"].Expires = DateTime.Now.AddDays(-1);
            }

            if (Session["auth_user"] != null)
            {
                Session["auth_user"] = null;
                Response.Redirect("authorization/loginForm.aspx");
                Response.Write("Thank-you you are logout!");
            }
        }
    }
}