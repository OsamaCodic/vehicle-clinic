using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Products
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            HttpCookie cookie = Request.Cookies["LoginCredentials"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["authUser_Email"]; // Session'll be start through Cookie

                if (Session["auth_user"] != null)
                {
                    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    {
                        var data = DB.products_with_Category();
                        productsList_gridview.DataSource = data;
                        productsList_gridview.DataBind();

                        totalRows.InnerText = "(" + DB.products_with_Category().Count() + ")";
                    }
                }
            }
            else
            {
                Response.Redirect("../authorization/loginForm.aspx");
            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            //Response.Write("<script>alert(" + product_id + ");</script>");

            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                DB.deleteProduct(product_id);
                Response.Redirect("index.aspx");
            }
        }
    }
}