using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Recruitment_Nhibernate.Models
{
    public class phieutuyendung
    {
        public virtual int ptd_id { get; set; }
        public virtual string ptd_ten { get; set; }
        public virtual System.DateTime ptd_ngaysinh { get; set; }
        public virtual string ptd_sdt { get; set; }
        public virtual bool ptd_gioitinh { get; set; }
        public virtual string ptd_chucvu { get; set; }
        public virtual string ptd_email { get; set; }
        public virtual int ttptd_id { get; set; }
        public virtual System.DateTime ptd_ngaydangphieu { get; set; }


    }
}