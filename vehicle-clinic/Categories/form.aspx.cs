using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Categories
{
    public partial class form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["authUser_Email"]; // Session'll be start through Cookie

                if (Request.QueryString["category_id"] == null)
                {
                    //Create Page
                    this.Title = "Categories | New category";
                    formTitle.InnerHtml = "Create new <small>Category</small>";
                    formCard.Attributes.Add("class", "card card-primary");
                    submitBtn.Text = "Create";
                    submitBtn.CssClass = "btn btn-primary";
                }
            }
            else
            {
                Response.Redirect("../authorization/loginForm.aspx");
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}