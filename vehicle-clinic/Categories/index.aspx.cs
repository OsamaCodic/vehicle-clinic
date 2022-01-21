using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vehicle_clinic.Categories
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "Categories | Index";

            using (vehicle_clinicEntities DB = new vehicle_clinicEntities())
            {
                var data = DB.getCategories();
                categoriesList_gridview.DataSource = data;
                categoriesList_gridview.DataBind();

                totalRows.InnerText = "(" + DB.getCategories().Count() + ")";
            }
        }
    }
}