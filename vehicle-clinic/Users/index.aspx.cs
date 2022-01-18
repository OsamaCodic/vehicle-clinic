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
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                // Session'll be start through Cookie
                Session["auth_user"] = cookie["authUser_Email"];
            }
            else
            {
                Response.Redirect("../authorization/loginForm.aspx");
            }
            
            if (Session["auth_user"] != null)
            {
                using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                {
                    var data = DB.readUsers();
                    usersList_gridview.DataSource = data;
                    usersList_gridview.DataBind();
                    
                    totalRows.InnerText = "(" + DB.readUsers().Count() + ")";
                }
            }
            else
            {
                Response.Redirect("../authorization/loginForm.aspx");
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32((sender as LinkButton).CommandArgument);

            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                DB.deleteUser(user_id);
                Response.Redirect("index.aspx");
            }

        }
    }
}