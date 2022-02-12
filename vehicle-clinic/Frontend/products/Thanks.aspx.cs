using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend.products
{
    public partial class Thanks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "VehicleClinic | Thanks";

            HttpCookie cookie = Request.Cookies["front_LoggedUser"];

            if (cookie != null)
            {
                Session["auth_user"] = cookie["front_userID"]; // Session'll be start through Cookie

                if (Session["auth_user"] != null && Session["purchase_productID"] != null && Session["purchase_productQty"] != null)
                {
                    ///Checkout pageload working here
                    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    {
                        int userID = Convert.ToInt32(cookie["front_userID"]);
                        user obj = DB.users.FirstOrDefault(c => c.user_id == userID);
                        thanksUser.InnerText = obj.first_name + obj.second_name + ", Thank-you for purchasing product!";
                    }
                }
                else
                {
                    Response.Redirect("index.aspx");
                }
            }
            else
            {
                Response.Redirect("../login/front_login.aspx");
            }
        }
    }
}