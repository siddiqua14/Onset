//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Onset.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class REPORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REPORT()
        {
            this.REPORTUSERS = new HashSet<REPORTUSER>();
        }
    
        public int REPORT_ID { get; set; }
        public string REPORT_BODY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTUSER> REPORTUSERS { get; set; }
    }
}