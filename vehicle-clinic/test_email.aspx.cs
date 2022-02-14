using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Net.Mail;

namespace vehicle_clinic
{
    public partial class test_email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendBtn_Click(object sender, EventArgs e)
        {
            MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new MailAddress("imusamatest@gmail.com");
            mail.To.Add("imosamaaslam@gmail.com");
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
        }
    }
}