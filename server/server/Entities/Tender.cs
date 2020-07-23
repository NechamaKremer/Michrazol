//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tender
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tender()
        {
            this.SuggestedPrices = new HashSet<SuggestedPrices>();
        }
    
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Nullable<decimal> MaxCost { get; set; }
        public int UserId { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<int> City { get; set; }
        public string Description { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public Nullable<bool> IsNew { get; set; }
    
        public virtual Cities Cities { get; set; }
        public virtual Products Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuggestedPrices> SuggestedPrices { get; set; }
        public virtual Users Users { get; set; }
    }
}
