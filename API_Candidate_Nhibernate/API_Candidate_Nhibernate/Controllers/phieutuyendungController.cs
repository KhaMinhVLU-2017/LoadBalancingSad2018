using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using API_Candidate_Nhibernate.Models;
using NHibernate;

namespace API_Candidate_Nhibernate.Controllers
{
    [EnableCors(origins: "http://localhost:53973,http://localhost:53689", headers: "*", methods: "*")]
    public class phieutuyendungController : ApiController
    {
        // GET: api/phieutuyendung
        public IEnumerable<phieutuyendung> Get()
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                var phieutuyendung = session.Query<phieutuyendung>().ToList();
                return phieutuyendung;
            }
        }

        // GET: api/phieutuyendung/5

        public phieutuyendung Get(int id)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                var phieudetail = session.Get<phieutuyendung>(id);
                return phieudetail;
            }
        }

        // POST: api/phieutuyendung
        public IHttpActionResult Post([FromBody]phieutuyendung model)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {

                phieutuyendung phieu = new phieutuyendung();

                phieu.ptd_ten = model.ptd_ten;
                phieu.ptd_sdt = model.ptd_sdt;
                phieu.ptd_ngaysinh = model.ptd_ngaysinh;
                phieu.ptd_gioitinh = model.ptd_gioitinh;
                phieu.ptd_email = model.ptd_email;
                phieu.ttptd_id = model.tinhtrangphieutuyendung.ttptd_id;
                phieu.ptd_ngaydangphieu = model.ptd_ngaydangphieu;

                phieu.ptd_chucvu = model.ptd_chucvu;

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(phieu);
                    transaction.Commit(); 
                    return Ok("{status:200,message: complete Save }");
                }
          
            }
        
        }

        // PUT: api/phieutuyendung/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/phieutuyendung/5
        public void Delete(int id)
        {
        }
    }
}
