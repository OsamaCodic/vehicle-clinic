using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Security.Cryptography;

namespace vehicle_clinic.Users
{
    public partial class form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"] != null)
                {



                if (Request.QueryString["user_id"] == null)
                {
                    formTitle.InnerHtml = "Create new <small>User</small>";
                    //formCard.Add("Class", "card card-primary");

                    ///formCard.Attr("Class", "card card-primary");
                
                    submitBtn.Text = "Create";
                }
                else
                {
                    formTitle.InnerHtml = "Edit <small>User</small>";
                    formCard.Style.Add("Class", "card card-Warning");
                    submitBtn.Text = "Update";
                }

                if (Request.QueryString["user_id"] != null)
                    {
                        
                        using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                        {
                            var userID = Convert.ToInt32(Request.QueryString["user_id"]);
                            user obj = DB.users.FirstOrDefault(u => u.user_id == userID);
                            first_name_txtbox.Text = obj.first_name;
                            second_name_txtbox.Text = obj.second_name;
                            email_txtbox.Text = obj.email;
                            display_order_txtbox.Text = obj.display_order;
                        }
                    }
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

                if (Request.QueryString["user_id"] == null) ////Create User
                {
                    ///Email should be unique
                    if (DB.users.Where(r => r.email == email_txtbox.Text).Count() > 0)
                    {
                        errorMessage.Style.Add("display", "block");
                        errorMessage.InnerHtml = "The email address is already taken. Please choose another";
                    }
                    else
                    {
                        obj = new user();
                        DB.users.Add(obj);
                    }
                }
                else ////Update User
                {
                    if (DB.users.Where(r => r.email == email_txtbox.Text).Count() > 0)
                    {
                        errorMessage.Style.Add("display", "block");
                        errorMessage.InnerHtml = "The email address is already taken. Please choose another";
                    }
                    else
                    {
                        var userID = Convert.ToInt32(Request.QueryString["user_id"]);
                        obj = DB.users.FirstOrDefault(u => u.user_id == userID);
                    }
                }

                obj.first_name = first_name_txtbox.Text;
                obj.second_name = second_name_txtbox.Text;
                obj.email = email_txtbox.Text;
                obj.password = password_txtbox.Text;
                obj.display_order = display_order_txtbox.Text;
                obj.role = Convert.ToInt32(roleList.SelectedValue);
                obj.created_at = System.DateTime.Now.ToString("yyyy-MM-dd");

                DB.SaveChanges();
                Response.Redirect("index.aspx");
            }
        }
    }
}