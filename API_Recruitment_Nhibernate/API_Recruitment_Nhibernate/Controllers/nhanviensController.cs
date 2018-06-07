using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using API_Recruitment_Nhibernate.Models;
using NHibernate;

namespace API_Recruitment_Nhibernate.Controllers
{
    [EnableCors(origins: "http://localhost:53973,http://localhost:53689,http://localhost:57943", headers: "*", methods: "*")]
    public class nhanviensController : ApiController
    {
        // GET: api/nhanviens
        public IEnumerable<nhanviens> Get()
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                var nhanvienlist = session.Query<nhanviens>().ToList();
                return nhanvienlist;
            }
        }

        // GET: api/nhanviens/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/nhanviens
        [HttpPost]
        [ResponseType(typeof(phieutuyendung))]
        public IHttpActionResult Post([FromBody]phieutuyendung model)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                phieutuyendung meo = session.Get<phieutuyendung>(model.ptd_id);
                nhanviens staff = new nhanviens();
                staff.nv_ten = meo.ptd_ten;
                staff.nv_ngaysinh = meo.ptd_ngaysinh;
                staff.nv_sdt = meo.ptd_sdt;
                staff.nv_gioitinh = meo.ptd_gioitinh;
                staff.cvu_id = int.Parse(meo.ptd_chucvu);
                staff.nv_email = meo.ptd_email;
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(staff);
                    session.Delete(meo);
                    transaction.Commit();
                    return Ok("{status:200,message: complete Save }");
                }
            }
        }

        // PUT: api/nhanviens/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/nhanviens/5
        public void Delete(int id)
        {
        }
    }
}
