//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderPlacer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    [DataContract(Name="OrderMaster",Namespace="OrderMaster")]
    public partial class OrderMaster
    {
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public int ItemId { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public System.DateTime OrderDate { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
    
        public virtual CustomerMaster CustomerMaster { get; set; }
        public virtual ItemMaster ItemMaster { get; set; }
    }
}
