using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Net.Mail;


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

                //User will Received Mail
                MailMessage mail = new System.Net.Mail.MailMessage();
                mail.From = new MailAddress("imusamatest@gmail.com");
                //mail.To.Add("imosamaaslam@gmail.com");
                mail.To.Add(email_txtbox.Text);
                mail.Subject = "VehicleClinic";
                mail.Body = "<h1>Thank-your for purchasing product from VehicleClinic</h1>";
                mail.IsBodyHtml = true;
                try
                {
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("imusamatest@gmail.com", "test123252");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        Response.Write("Mail Send successfully!");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Mail sending failed!");
                }

                //When user purchased product then empty his cart
                HttpCookie cookie = Request.Cookies["front_LoggedUser"];
                int userID = Convert.ToInt32(cookie["front_userID"]);
                DB.emptyCartTable(userID);

                Response.Redirect("Thanks.aspx");
            }
            
        }

        protected void discardBtn_Click(object sender, EventArgs e)
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                HttpCookie cookie = Request.Cookies["front_LoggedUser"];
                int userID = Convert.ToInt32(cookie["front_userID"]);
                DB.emptyCartTable(userID);
                Response.Redirect("index.aspx");
            }
        }
    }
}