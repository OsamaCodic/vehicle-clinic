using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Brands
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["authUser_Email"]; // Session'll be start through Cookie

                if (IsPostBack) return; //If PostBack is true don't fill form form will fill first time

                if (Request.QueryString["brand_id"] == null)
                {
                    //Create Page
                    this.Title = "Brands | New brand";
                    formTitle.InnerHtml = "Create new <small>Brand</small>";
                    formCard.Attributes.Add("class", "card card-primary");
                    submitBtn.Text = "Create";
                    submitBtn.CssClass = "btn btn-primary";
                }
                else
                {
                    //Edit Page
                    this.Title = "Brands | Edit Brands";
                    formTitle.InnerHtml = "Edit <small>Brand</small>";
                    formCard.Attributes.Add("class", "card card-warning");
                    submitBtn.Text = "Update";
                    submitBtn.CssClass = "btn btn-warning";

                    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    {
                        var brandID = Convert.ToInt32(Request.QueryString["brand_id"]);
                        brand obj = DB.brands.FirstOrDefault(brnd => brnd.brand_id == brandID);
                        title_txtbox.Text = obj.brand_title;
                        description_txtbox.Text = obj.brand_description;
                        display_order_txtbox.Text = obj.brand_display_order.ToString();
                        preview_Image.ImageUrl = "../public/upload_files/" + obj.brand_logo;
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
            HttpPostedFile postedImage = brandLogo.PostedFile;
            string image_name = Path.GetFileName(postedImage.FileName);
            string image_extension = Path.GetExtension(image_name);
            
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                brand obj = new brand();

                if (Request.QueryString["brand_id"] == null)
                {   
                    //Add product
                    if (brandLogo.HasFile)
                    {
                        if (image_extension.ToLower() == ".jpg" || image_extension.ToLower() == ".jpeg" || image_extension.ToLower() == ".png" || image_extension.ToLower() == ".bmp")
                        {
                            obj.brand_title = title_txtbox.Text;
                            obj.brand_description = description_txtbox.Text;
                            obj.brand_display_order = Convert.ToInt32(display_order_txtbox.Text);
                            obj.created_at = System.DateTime.Now.ToString("yyyy-MM-dd");
                            obj.brand_logo = image_name;
                            brandLogo.SaveAs(Server.MapPath("~/public/upload_files/" + image_name));
                            DB.brands.Add(obj);

                            DB.SaveChanges();
                            Response.Redirect("index.aspx");
                        }
                        else
                        {
                            custom_logo_required.InnerHtml = "Only Images (.jpg, .jpeg, .png, .bmp) are allowed!";
                        }   
                    }
                    else
                    {
                        custom_logo_required.InnerHtml = "Images must be requied!";
                    }          
                }
                else
                {
                    //Update Product
                    var brandID = Convert.ToInt32(Request.QueryString["brand_id"]);
                    obj = DB.brands.FirstOrDefault(brnd => brnd.brand_id == brandID);

                    obj.brand_title = title_txtbox.Text;
                    obj.brand_description = description_txtbox.Text;
                    obj.brand_display_order = Convert.ToInt32(display_order_txtbox.Text);
                    obj.updated_at = System.DateTime.Now.ToString("yyyy-MM-dd");
                            
                    if (brandLogo.HasFile)
                    {
                        if (image_extension.ToLower() == ".jpg" || image_extension.ToLower() == ".jpeg" || image_extension.ToLower() == ".png" || image_extension.ToLower() == ".bmp")
                        {
                            obj.brand_logo = image_name;
                            brandLogo.SaveAs(Server.MapPath("~/public/upload_files/" + image_name));
                        }
                        else
                        {
                            custom_logo_required.InnerHtml = "Only Images (.jpg, .jpeg, .png, .bmp) are allowed!";
                        }
                     }
                    DB.SaveChanges();
                    Response.Redirect("index.aspx");
                }
               
            }
        }
    }
}