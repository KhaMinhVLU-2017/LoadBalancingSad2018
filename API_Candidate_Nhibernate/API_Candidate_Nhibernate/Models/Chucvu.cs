using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Candidate_Nhibernate.Models
{
    public class Chucvu
    {
        public virtual int cvu_id { get; set; }
        public virtual string cvu_ten { get; set; }
    }
}