//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Candidate.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tuyendung
    {
        public int td_id { get; set; }
        public string td_ten { get; set; }
        public string td_noidung { get; set; }
        public System.DateTime td_ngaybatdau { get; set; }
        public System.DateTime td_ngayketthuc { get; set; }
        public int tttd_id { get; set; }
    
        public virtual tinhtrangdottuyendung tinhtrangdottuyendung { get; set; }
    }
}
