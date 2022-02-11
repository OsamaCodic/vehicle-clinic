using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Frontend
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                var data = DB.products_with_Category();
                productsRepeater.DataSource = data;
                productsRepeater.DataBind();
            }
        }
    }
}