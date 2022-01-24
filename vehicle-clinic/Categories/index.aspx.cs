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
        
        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            int category_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            //Response.Write("<script>alert(" + category_id + ");</script>");

            try
            {
                using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                {
                    DB.deleteCategory(category_id);
                    Response.Redirect("index.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Brand used in products');</script>");
                //throw;
            }
        }
    }
}