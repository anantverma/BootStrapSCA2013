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
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    
    public partial class Cart
    {
    	[DataMember]
        public int Id { get; set; }
    	[DataMember]
        public int ProductId { get; set; }
    	[DataMember]
        public string ProductName { get; set; }
    	[DataMember]
        public string ProductCategory { get; set; }
    	[DataMember]
        public decimal ProductPrice { get; set; }
    	[DataMember]
        public int ProductQuantity { get; set; }
    	[DataMember]
        public bool IsShoppingCart { get; set; }
    }
}
