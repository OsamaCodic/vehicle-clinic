using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Users
{
    public partial class users_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Get auth user
            if (Session["auth_user"] != null)
            {
                //Response.Write("Welcom to Dashboard" + "<br/>" + "Admin:" + Session["auth_user"].ToString());
               
            }
            else
            {
                Response.Redirect("../authorization/loginForm.aspx");
            }
        }
        
    }
}