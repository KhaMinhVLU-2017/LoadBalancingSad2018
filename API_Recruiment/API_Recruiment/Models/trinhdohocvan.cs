//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Recruiment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class trinhdohocvan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trinhdohocvan()
        {
            this.nhanviens = new HashSet<nhanvien>();
        }
    
        public int tdhv_id { get; set; }
        public string tdhv_ten { get; set; }
        public string tdhv_chuyennganh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhanvien> nhanviens { get; set; }
    }
}
