using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend.login
{
    public partial class registerUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "VehicleClinic | Register";
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                {
                    //Email should be unique
                    if (DB.users.Where(r => r.email == email_txtbox.Text).Count() > 0)
                    {
                        errorMessage.Style.Add("display", "block");
                        errorMessage.InnerHtml = "The email address is already taken. Please choose another";
                    }
                    else
                    {
                        user obj = new user();

                        obj.first_name = first_name_txtbox.Text;
                        obj.second_name = second_name_txtbox.Text;
                        obj.email = email_txtbox.Text;
                        obj.password = password_txtbox.Text;
                        obj.role = Convert.ToInt32("2");
                        obj.created_at = System.DateTime.Now.ToString("yyyy-MM-dd");

                        DB.users.Add(obj);
                        DB.SaveChanges();
                        Response.Redirect("front_login.aspx");
                    }
                }
            }
            else
            {
                Response.Write("Form not submitted!");
            }
        }
    }
}