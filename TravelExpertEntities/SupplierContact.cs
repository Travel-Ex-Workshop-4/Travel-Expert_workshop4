//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelExpertEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplierContact
    {
        public int SupplierContactId { get; set; }
        public string SupConFirstName { get; set; }
        public string SupConLastName { get; set; }
        public string SupConCompany { get; set; }
        public string SupConAddress { get; set; }
        public string SupConCity { get; set; }
        public string SupConProv { get; set; }
        public string SupConPostal { get; set; }
        public string SupConCountry { get; set; }
        public string SupConBusPhone { get; set; }
        public string SupConFax { get; set; }
        public string SupConEmail { get; set; }
        public string SupConURL { get; set; }
        public string AffiliationId { get; set; }
        public Nullable<int> SupplierId { get; set; }
    
        public virtual Affiliation Affiliation { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}