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

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedImage = productImages.PostedFile;

            string image_name = Path.GetFileName(postedImage.FileName);
            string image_extension = Path.GetExtension(image_name);

            

            if (
                image_extension.ToLower() == ".jpg" || 
                image_extension.ToLower() == ".jpeg" ||
                image_extension.ToLower() == ".png" || 
                image_extension.ToLower() == ".bmp" 
                )
            {
                using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
                {
                    product obj = new product();

                    obj.file_name = image_name;
                    productImages.SaveAs(Server.MapPath("~/public/upload_files/" + image_name));

                    DB.products.Add(obj);
                    DB.SaveChanges();
                }
            }
            else
            {
                Response.Write("Only Images (.jpg, .jpeg, .png, .bmp) are allowed!");    
            }

            Response.Redirect("index.aspx");
        }
    }
}