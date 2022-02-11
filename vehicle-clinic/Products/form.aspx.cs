using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace vehicle_clinic.Products
{
    public partial class form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["authUser_Email"]; // Session'll be start through Cookie

                if (Session["auth_user"] != null)
                {
                    if (IsPostBack) return;

                    loadCateogries();
                    loadBrands();

                    if (Request.QueryString["product_id"] == null)
                    {
                        //Create Page
                        this.Title = "Products | New product";
                        formTitle.InnerHtml = "Create new <small>Product</small>";
                        formCard.Attributes.Add("class", "card card-primary");
                        submitBtn.Text = "Add product";
                        submitBtn.CssClass = "btn btn-primary";
                    }
                    else
                    {
                        //Edit Page
                        this.Title = "Products | Edit product";
                        formTitle.InnerHtml = "Edit <small>Product</small>";
                        formCard.Attributes.Add("class", "card card-warning");
                        submitBtn.Text = "Update";
                        submitBtn.CssClass = "btn btn-warning";

                        using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                        {
                            var productID = Convert.ToInt32(Request.QueryString["product_id"]);
                            product obj = DB.products.FirstOrDefault(prod => prod.product_id == productID);
                            categoriesList.Items.FindByValue(obj.category_id.ToString()).Selected = true;
                            brandsList.Items.FindByValue(obj.brand_title.ToString()).Selected = true;
                            product_name_txtbox.Text = obj.product_name;
                            product_price_txtbox.Text = obj.product_price.ToString();
                            description_txtbox.Text = obj.product_description2;
                            product_colours_txtbox.Text = obj.product_colours;
                            dimensions_txtbox.Text = obj.product_dimensions;
                            weight_txtbox.Text = obj.product_weight.ToString();
                            taxlist.Items.FindByValue(obj.product_tax.ToString()).Selected = true;
                            discountList.Items.FindByValue(obj.product_discount.ToString()).Selected = true;
                            release_date_txtbox.Text = obj.release_date;
                            delivered_time_txtbox.Text = obj.delived_time;
                            sold_txtbox.Text = obj.total_sold.ToString();
                            manufacture_type_list.Items.FindByValue(obj.manufactured_type.ToString()).Selected = true;
                            availible_qty_txtbox.Text = obj.availible_quantity.ToString();
                            display_order_txtbox.Text = obj.display_order.ToString();

                            preview_Image.ImageUrl = "../public/upload_files/" + obj.file_name;                         
                        }
                    }
                }
            }
            else
            {
                Response.Redirect("../authorization/loginForm.aspx");
            }   
        }

        private void loadCateogries()
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                var data = DB.getCategories();
                categoriesList.DataSource = data;
                categoriesList.DataTextField = "category_title";
                categoriesList.DataValueField = "category_id";
                categoriesList.DataBind();
            }
        }

        private void loadBrands()
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                var data = DB.loadBrands();
                brandsList.DataSource = data;
                brandsList.DataTextField = "brand_title";
                brandsList.DataValueField = "brand_id";
                brandsList.DataBind();
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedImage = productImages.PostedFile;
            string image_name = Path.GetFileName(postedImage.FileName);
            string image_extension = Path.GetExtension(image_name);
           
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                product obj = new product();
                   
                if (Request.QueryString["product_id"] == null)
                {
                    //Add product
                    if (productImages.HasFile)
                    {
                        if (image_extension.ToLower() == ".jpg" || image_extension.ToLower() == ".jpeg" || image_extension.ToLower() == ".png" || image_extension.ToLower() == ".bmp")
                        {
                            obj.category_id = Convert.ToInt32(categoriesList.SelectedValue);
                            obj.brand_title = brandsList.SelectedValue;
                            obj.product_name = product_name_txtbox.Text;
                            obj.product_price = Convert.ToInt32(product_price_txtbox.Text);
                            obj.product_description2 = description_txtbox.Text;
                            obj.product_colours = product_colours_txtbox.Text;
                            obj.product_dimensions = dimensions_txtbox.Text;
                            obj.product_weight = Convert.ToInt32(weight_txtbox.Text);
                            obj.product_tax = Convert.ToInt32(taxlist.SelectedValue);
                            obj.product_discount = Convert.ToInt32(discountList.SelectedValue);
                            obj.release_date = release_date_txtbox.Text;
                            obj.total_sold = Convert.ToInt32(sold_txtbox.Text);
                            obj.manufactured_type = manufacture_type_list.SelectedValue;
                            obj.availible_quantity = Convert.ToInt32(availible_qty_txtbox.Text);
                            obj.delived_time = delivered_time_txtbox.Text;
                            obj.display_order = Convert.ToInt32(display_order_txtbox.Text);
                            obj.created_at = System.DateTime.Now.ToString("yyyy-MM-dd");
                            obj.file_name = image_name;
                            productImages.SaveAs(Server.MapPath("~/public/upload_files/" + image_name));

                            DB.products.Add(obj);
                            DB.SaveChanges();
                            Response.Redirect("index.aspx");
                        }
                        else
                        {
                            img_custom_requied.InnerHtml = "Only Images (.jpg, .jpeg, .png, .bmp) are allowed!";
                        }
                    }
                    else
                    {
                        img_custom_requied.InnerHtml = "Image must be requied!";
                    }
                }
                else
                {
                    //Update Product
                    var productID = Convert.ToInt32(Request.QueryString["product_id"]);
                    obj = DB.products.FirstOrDefault(prod => prod.product_id == productID);

                    obj.category_id = Convert.ToInt32(categoriesList.SelectedValue);
                    obj.brand_title = brandsList.SelectedValue;
                    obj.product_name = product_name_txtbox.Text;
                    obj.product_price = Convert.ToInt32(product_price_txtbox.Text);
                    obj.product_description2 = description_txtbox.Text;
                    obj.product_colours = product_colours_txtbox.Text;
                    obj.product_dimensions = dimensions_txtbox.Text;
                    obj.product_weight = Convert.ToInt32(weight_txtbox.Text);
                    obj.product_tax = Convert.ToInt32(taxlist.SelectedValue);
                    obj.product_discount = Convert.ToInt32(discountList.SelectedValue);
                    obj.release_date = release_date_txtbox.Text;
                    obj.total_sold = Convert.ToInt32(sold_txtbox.Text);
                    obj.manufactured_type = manufacture_type_list.SelectedValue;
                    obj.availible_quantity = Convert.ToInt32(availible_qty_txtbox.Text);
                    obj.delived_time = delivered_time_txtbox.Text;
                    obj.display_order = Convert.ToInt32(display_order_txtbox.Text);
                    obj.updated_at = System.DateTime.Now.ToString("yyyy-MM-dd");

                    if (productImages.HasFile)
                    {
                        if (image_extension.ToLower() == ".jpg" || image_extension.ToLower() == ".jpeg" || image_extension.ToLower() == ".png" || image_extension.ToLower() == ".bmp")
                        {
                            obj.file_name = image_name;
                            productImages.SaveAs(Server.MapPath("~/public/upload_files/" + image_name));
                        }
                        else
                        {
                            img_custom_requied.InnerHtml = "Only Images (.jpg, .jpeg, .png, .bmp) are allowed!";
                        }
                    }

                    DB.SaveChanges();
                    Response.Redirect("index.aspx");
                }
            }
        }
    }
}