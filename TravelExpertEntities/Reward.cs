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
    
    public partial class Reward
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reward()
        {
            this.Customers_Rewards = new HashSet<Customers_Rewards>();
        }
    
        public int RewardId { get; set; }
        public string RwdName { get; set; }
        public string RwdDesc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers_Rewards> Customers_Rewards { get; set; }
    }
}
