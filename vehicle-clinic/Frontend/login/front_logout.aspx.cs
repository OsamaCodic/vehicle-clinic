using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend.login
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "VehicleClinic | Login";

            HttpCookie cookie = Request.Cookies["front_LoggedUser"];

            if (cookie != null)
            {
                Response.Cookies["front_LoggedUser"].Expires = DateTime.Now.AddDays(-1);

                if (Session["front_logged_userID"] != null)
                {
                    //Destory all frontend sessions variable
                    Session["front_logged_userID"] = null;
                    Session["purchase_productID"] = null;
                    Session["purchase_productQty"] = null;

                    using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                    {
                        DB.discardCart();
                    }

                }
                
            }
            
            Response.Redirect("front_login.aspx");
        }
    }
}