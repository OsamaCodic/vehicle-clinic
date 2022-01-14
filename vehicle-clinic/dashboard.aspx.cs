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
            if (Session["auth_user"] != null)
            {
                ///Page load working here
            




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