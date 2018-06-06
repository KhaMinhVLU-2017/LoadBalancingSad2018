using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Recruitment_Nhibernate.Models
{
    public class nhanviens
    {
        public virtual int nv_id { get; set; }
        public virtual string nv_ten { get; set; }
        public virtual Nullable<System.DateTime> nv_ngaysinh { get; set; }
        public virtual string nv_diachi { get; set; }
        public virtual string nv_sdt { get; set; }
        public virtual Nullable<bool> nv_gioitinh { get; set; }
        public virtual Nullable<int> pb_id { get; set; }
        public virtual Nullable<int> cvu_id { get; set; }
        public virtual Nullable<int> tdhv_id { get; set; }
        public virtual Nullable<int> lg_bacluong { get; set; }
        public virtual string nv_tinhtrang { get; set; }
        public virtual Nullable<int> tt_id { get; set; }
        public virtual Nullable<bool> loai { get; set; }
        public virtual string nv_email { get; set; }
    }
}