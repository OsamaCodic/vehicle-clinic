using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Users
{
    public partial class form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (Session["auth_user"] != null)
                {
                    ///Page load working here
                




                }
                else
                {
                    Response.Redirect("../authorization/loginForm.aspx");
                }
            
        }
        

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                user obj = new user();
                obj.first_name = first_name_txtbox.Text;
                obj.second_name = second_name_txtbox.Text;
                obj.email = email_txtbox.Text;
                obj.password = password_txtbox.Text;

                DB.users.Add(obj);
                DB.SaveChanges();

                Response.Redirect("index.aspx");

            }
        }
    }
}