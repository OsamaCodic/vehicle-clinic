using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Categories
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["authUser_Email"]; // Session'll be start through Cookie

                if (Session["auth_user"] != null)
                {
                    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    {
                        var data = DB.getCategories();
                        categoriesList_gridview.DataSource = data;
                        categoriesList_gridview.DataBind();

                        totalRows.InnerText = "(" + DB.getCategories().Count() + ")";
                    }
                }
            }
            else
            {
                Response.Redirect("../authorization/loginForm.aspx");
            }
        }
    }
}