//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vehicle_clinic
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int product_id { get; set; }
        public Nullable<int> category_id { get; set; }
        public string brand_title { get; set; }
        public string product_name { get; set; }
        public Nullable<double> product_price { get; set; }
        public byte[] product_description { get; set; }
        public string product_colours { get; set; }
        public string product_dimensions { get; set; }
        public Nullable<double> product_weight { get; set; }
        public Nullable<int> product_tax { get; set; }
        public Nullable<int> product_discount { get; set; }
        public string release_date { get; set; }
        public Nullable<int> total_sold { get; set; }
        public string manufactured_type { get; set; }
        public Nullable<int> availible_quantity { get; set; }
        public string delived_time { get; set; }
        public Nullable<int> display_order { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    
        public virtual category category { get; set; }
    }
}
