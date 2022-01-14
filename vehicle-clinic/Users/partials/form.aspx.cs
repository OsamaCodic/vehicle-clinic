using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Users
{
    public partial class form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Get auth user
            if (Session["auth_user"] != null)
            {
                Response.Write("Admin:" + Session["auth_user"].ToString());
            }
            else
            {
                Response.Redirect("../../authorization/loginForm.aspx");
            }
        }
        
        protected void save_user_Btn_Click(object sender, EventArgs e)
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                user obj = new user();
                obj.first_name = first_name.Text;
                obj.second_name = second_name.Text;
                obj.email = email.Text;
                obj.password = password.Text;
                
                DB.users.Add(obj);

                DB.SaveChanges();
                Response.Write("<br> User created successfully!");
                
                ///Now empty form inputs values
                first_name.Text = "";
                second_name.Text = "";
                email.Text = "";
                password.Text = "";
            }


        }
    }
}