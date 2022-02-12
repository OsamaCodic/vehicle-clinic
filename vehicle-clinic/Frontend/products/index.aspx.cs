using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend.products
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "VehicleClinic | All Products";

            HttpCookie cookie = Request.Cookies["front_LoggedUser"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["front_userID"]; // Session'll be start through Cookie

                if (Session["auth_user"] != null)
                {
                    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    {
                        var data = DB.products_with_Category_and_Brand();


                        front_productsRepeater.DataSource = data;
                        

                        front_productsRepeater.DataBind();
                    }
                }
            }
            else
            {
                Response.Redirect("../login/front_login.aspx");
            }
        }
    }
}