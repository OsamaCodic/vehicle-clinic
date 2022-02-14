using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend.products
{
    public partial class cart : System.Web.UI.Page
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
                    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    {
                        int userID = Convert.ToInt32(cookie["front_userID"]);
                        var data = DB.user_cart(userID);
                        cartList_gridview.DataSource = data;
                        cartList_gridview.DataBind();
                    }
                }
            }
            else
            {
                Response.Redirect("../login/front_login.aspx");
            }
        }

        protected void discardCart_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["front_LoggedUser"];
            int userID = Convert.ToInt32(cookie["front_userID"]);

            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                DB.emptyCartTable(userID);
                Response.Redirect("index.aspx");
            }
        }
    }
}