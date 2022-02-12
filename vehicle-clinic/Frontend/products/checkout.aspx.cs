using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend.products
{
    public partial class checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "VehicleClinic | Cart list";

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
                        first_name_txtbox.Text = obj.first_name;
                        second_name_txtbox.Text = obj.second_name;
                        email_txtbox.Text = obj.email;
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

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                purchaseTbl obj = new purchaseTbl();
                obj.first_name = first_name_txtbox.Text;
                obj.second_name = second_name_txtbox.Text;
                obj.country = countryList.SelectedValue;
                obj.address = addressTxtbox.Text;
                obj.email2 = email_txtbox.Text;
                obj.contact = Convert.ToInt32(contact_txbox.Text);

                DB.purchaseTbls.Add(obj);
                DB.SaveChanges();
                Response.Redirect("Thanks.aspx");
            }
        }

        protected void discardBtn_Click(object sender, EventArgs e)
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                DB.discardCart();
                Response.Redirect("index.aspx");
            }
        }
    }
}