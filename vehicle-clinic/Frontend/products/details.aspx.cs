using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend.buy_product
{
    public partial class product_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            this.Title = "VehicleClinic | Cart list";

            HttpCookie cookie = Request.Cookies["front_LoggedUser"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["front_userID"]; // Session'll be start through Cookie

                if (Session["auth_user"] != null)
                {
                    //Store buy product into Cart
                    if (Request.QueryString["product_id"] != null)
                    {
                        using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                        {
                            cart obj = new cart();
                            obj.product_id = Convert.ToInt32(Request.QueryString["product_id"]);
                            obj.user_id = Convert.ToInt32(cookie["front_userID"]);
                            DB.carts.Add(obj);
                            DB.SaveChanges();

                            int productID = Convert.ToInt32(Request.QueryString["product_id"]);
                            
                            //Show Product Details
                            product p = DB.products.FirstOrDefault(prod => prod.product_id == productID); //Get Product
                            preview_Image.ImageUrl = "../../public/upload_files/" + p.file_name;
                            name_render.InnerHtml = p.product_name;
                            price_render.InnerHtml = p.product_price.ToString();
                            
                        }
                    }
                    else
                    {
                        Response.Redirect("index.aspx");
                    }
                }
            }
            else
            {
                Response.Redirect("../login/front_login.aspx");
            }
        }

        protected void minusBtn_Click(object sender, EventArgs e)
        {

            int txtbox = Convert.ToInt32(quanty_txtbox.Text);

            int total = txtbox - 1;

            if (total > 0)
            {
                quanty_txtbox.Text = total.ToString();
            }
            
        }

        protected void plusBtn_Click(object sender, EventArgs e)
        {
            int txtbox = Convert.ToInt32(quanty_txtbox.Text);

            int total = txtbox + 1;

            quanty_txtbox.Text = total.ToString();
            
        }

        protected void checkoutBtn_Click(object sender, EventArgs e)
        {
            string productID = productID_hiddenField.Value.ToString();
            int product_quantity = Convert.ToInt32(quanty_txtbox.Text);

            Session["purchase_productID"] = productID;
            Session["purchase_productQty"] = product_quantity;

            Response.Redirect("checkout.aspx");
        }
    }
}