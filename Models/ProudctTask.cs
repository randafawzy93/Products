//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Products.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProudctTask
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> amount { get; set; }
        public System.DateTime bought_date { get; set; }
    }
}
