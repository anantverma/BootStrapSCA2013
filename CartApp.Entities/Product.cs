//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CartApp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public int ProductDetailId { get; set; }
        public bool IsSold { get; set; }
        public Nullable<System.DateTime> StockInDate { get; set; }
        public Nullable<System.DateTime> SoldDate { get; set; }
    
        public virtual ProductDescription ProductDescription { get; set; }
    }
}