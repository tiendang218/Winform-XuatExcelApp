//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XuatExcelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAI_HS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_HS()
        {
            this.CT_HCC = new HashSet<CT_HCC>();
        }
    
        public string MA_LOAI_HS { get; set; }
        public string TEN_LOAI_HS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HCC> CT_HCC { get; set; }
    }
}
