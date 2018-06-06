using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using API_Candidate.Models;

namespace API_Candidate.Controllers7
{
    [EnableCors(origins: "http://localhost:53973,http://localhost:53689", headers: "*", methods: "*")]
    public class chucvusController : ApiController
    { 
        private SAD2018Entities db = new SAD2018Entities();

        // GET: api/chucvus
        public IEnumerable<chucvu> Getchucvus()
        {
            List<chucvu> meo = new List<chucvu>();
            foreach(var item in db.chucvus)
            {
                meo.Add(new chucvu{
                    cvu_id= item.cvu_id,
                    cvu_ten = item.cvu_ten
                });
            }
            return meo;
        }

        // GET: api/chucvus/5
        [ResponseType(typeof(chucvu))]
        public async Task<IHttpActionResult> Getchucvu(int id)
        {
            chucvu chucvu = await db.chucvus.FindAsync(id);
            if (chucvu == null)
            {
                return NotFound();
            }

            return Ok(chucvu);
        }

        // PUT: api/chucvus/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putchucvu(int id, chucvu chucvu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chucvu.cvu_id)
            {
                return BadRequest();
            }

            db.Entry(chucvu).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!chucvuExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/chucvus
        [ResponseType(typeof(chucvu))]
        public async Task<IHttpActionResult> Postchucvu(chucvu chucvu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.chucvus.Add(chucvu);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = chucvu.cvu_id }, chucvu);
        }

        // DELETE: api/chucvus/5
        [ResponseType(typeof(chucvu))]
        public async Task<IHttpActionResult> Deletechucvu(int id)
        {
            chucvu chucvu = await db.chucvus.FindAsync(id);
            if (chucvu == null)
            {
                return NotFound();
            }

            db.chucvus.Remove(chucvu);
            await db.SaveChangesAsync();

            return Ok(chucvu);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool chucvuExists(int id)
        {
            return db.chucvus.Count(e => e.cvu_id == id) > 0;
        }
    }
}