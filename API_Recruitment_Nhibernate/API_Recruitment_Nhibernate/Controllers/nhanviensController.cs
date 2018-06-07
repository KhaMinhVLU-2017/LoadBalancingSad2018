using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
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
        public void Post([FromBody]string value)
        {
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
