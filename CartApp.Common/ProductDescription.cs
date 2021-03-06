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
    [KnownType(typeof(Brand))]
    [KnownType(typeof(Category))]
    [KnownType(typeof(Color))]
    [KnownType(typeof(CustomerType))]
    [KnownType(typeof(Product))]
    [KnownType(typeof(Size))]
    
    public partial class ProductDescription
    {
        public ProductDescription()
        {
            this.Products = new HashSet<Product>();
        }
    
    	[DataMember]
        public int Id { get; set; }
    	[DataMember]
        public string ProductName { get; set; }
    	[DataMember]
        public string ProductDescription1 { get; set; }
    	[DataMember]
        public Nullable<int> Brand { get; set; }
    	[DataMember]
        public Nullable<int> Color { get; set; }
    	[DataMember]
        public Nullable<int> Size { get; set; }
    	[DataMember]
        public Nullable<int> Category { get; set; }
    	[DataMember]
        public Nullable<int> Customer { get; set; }
    	[DataMember]
        public decimal Price { get; set; }
    	[DataMember]
        public byte[] Image { get; set; }
    
    	[DataMember]
        public virtual Brand Brand1 { get; set; }
    	[DataMember]
        public virtual Category Category1 { get; set; }
    	[DataMember]
        public virtual Color Color1 { get; set; }
    	[DataMember]
        public virtual CustomerType CustomerType { get; set; }
    	[DataMember]
        public virtual ICollection<Product> Products { get; set; }
    	[DataMember]
        public virtual Size Size1 { get; set; }
    }
}
