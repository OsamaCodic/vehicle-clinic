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
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["authUser_Email"]; // Session'll be start through Cookie

                if (Session["auth_user"] != null)
                {
                    if (Request.QueryString["user_id"] == null)
                    {
                        //Create Page
                        this.Title = "Users | New user";
                        formTitle.InnerHtml = "Create new <small>User</small>";
                        formCard.Attributes.Add("class", "card card-primary");
                        submitBtn.Text = "Create";
                        submitBtn.CssClass = "btn btn-primary";
                    }
                    else
                    {
                        //Edit Page
                        this.Title = "Users | Edit User";
                        formTitle.InnerHtml = "Edit <small>User</small>";
                        formCard.Attributes.Add("class", "card card-warning");
                        submitBtn.Text = "Update";
                        submitBtn.CssClass = "btn btn-warning";
                        password_txtbox.Attributes.Add("placeholder", "Your new password");
                        confirm_password_txtbox.Attributes.Add("placeholder", "Confirm new password");
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
            }
            else
            {
                Response.Redirect("../authorization/loginForm.aspx");
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                {
                    if (Request.QueryString["user_id"] == null) //Create User
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
                            obj.display_order = display_order_txtbox.Text;
                            obj.role = Convert.ToInt32(roleList.SelectedValue);
                            obj.created_at = System.DateTime.Now.ToString("yyyy-MM-dd");

                            DB.users.Add(obj);
                            DB.SaveChanges();
                            Response.Redirect("index.aspx");
                        }
                    }
                    else //Update User
                    {
                        var userID = Convert.ToInt32(Request.QueryString["user_id"]);
                        user obj = DB.users.FirstOrDefault(u => u.user_id == userID);

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
            else
            {
                Response.Write("Form not submitted!");
            }
        }
    }
}