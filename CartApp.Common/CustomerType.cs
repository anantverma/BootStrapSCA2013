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
    [KnownType(typeof(ProductDescription))]
    
    public partial class CustomerType
    {
        public CustomerType()
        {
            this.ProductDescriptions = new HashSet<ProductDescription>();
        }
    
    	[DataMember]
        public int Id { get; set; }
    	[DataMember]
        public string CustomerType1 { get; set; }
    
    	[DataMember]
        public virtual ICollection<ProductDescription> ProductDescriptions { get; set; }
    }
}