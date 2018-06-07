using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using API_Candidate_Nhibernate.Models;
using NHibernate;

namespace API_Candidate_Nhibernate.Controllers
{
    [EnableCors(origins: "http://localhost:53973,http://localhost:53689,http://localhost:56707", headers: "*", methods: "*")]
    public class chucvusController : ApiController
    {
        // GET: api/chucvu 
        public IEnumerable<Chucvu> Get()
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                var chucvus = session.Query<Chucvu>().ToList();
                return chucvus;
            }
        }

        // GET: api/chucvu/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/chucvu
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/chucvu/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/chucvu/5
        public void Delete(int id)
        {
        }
    }
}
