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
            

            if (Request.Cookies["LoginCredentials"] != null)
            {
                //Session["auth_user"] = Request.Cookies["LoginCredentials"]["authUser_Email"];

                Session["auth_user"] = Request.Cookies["LoginCredentials"].Value;

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