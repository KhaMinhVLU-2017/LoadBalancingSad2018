using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API_Candidate.Models;
using System.Web.Http.Cors;

namespace API_Candidate.Controllers
{
    [EnableCors(origins: "http://localhost:53973,http://localhost:53689,http://localhost:56707,http://localhost:57943", headers: "*", methods: "*")]
    
    public class phieutuyendungsController : ApiController
    {
        private SAD2018Entities db = new SAD2018Entities();


        // GET: api/phieutuyendungs
        public IEnumerable<phieutuyendung> Getphieutuyendungs()
        {
            List<phieutuyendung> meo = new List<phieutuyendung>();
 
            foreach (var item in db.phieutuyendungs)
            {
                meo.Add(new phieutuyendung
                {
                    ptd_id = item.ptd_id,
                    ptd_ten = item.ptd_ten,
                    ptd_gioitinh = item.ptd_gioitinh,
                    ptd_email = item.ptd_email,
                    ptd_sdt = item.ptd_sdt,
                    ptd_ngaysinh = item.ptd_ngaysinh,
                    ptd_chucvu = item.ptd_chucvu,
                    ptd_ngaydangphieu = item.ptd_ngaydangphieu,
                    tinhtrangphieutuyendung = new tinhtrangphieutuyendung {
                        ttptd_id=item.tinhtrangphieutuyendung.ttptd_id,
                        ttptd_ten= item.tinhtrangphieutuyendung.ttptd_ten
                    }
                });
            }
            return meo;
        }

        // GET: api/phieutuyendungs/5
        [ResponseType(typeof(phieutuyendung))]
        public IHttpActionResult Getphieutuyendung(int id)

        {
            phieutuyendung phieutuyendung = db.phieutuyendungs.Find(id);
            phieutuyendung meo = new phieutuyendung();
            meo.ptd_id = phieutuyendung.ptd_id;
            meo.ptd_ten = phieutuyendung.ptd_ten;
            meo.ptd_sdt = phieutuyendung.ptd_sdt;
            meo.ptd_ngaysinh = phieutuyendung.ptd_ngaysinh;
            meo.ptd_gioitinh = phieutuyendung.ptd_gioitinh;
            meo.ptd_chucvu = phieutuyendung.ptd_chucvu;
            meo.ptd_email = phieutuyendung.ptd_email;
            meo.tinhtrangphieutuyendung = new tinhtrangphieutuyendung {ttptd_id =phieutuyendung.tinhtrangphieutuyendung.ttptd_id,ttptd_ten= phieutuyendung.tinhtrangphieutuyendung.ttptd_ten};
           
            if (phieutuyendung == null)
            {
                return NotFound();
            }

            return Ok(meo); 
        }

        // PUT: api/phieutuyendungs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putphieutuyendung(int id, phieutuyendung phieutuyendung)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != phieutuyendung.ptd_id)
            {
                return BadRequest();
            }

            db.Entry(phieutuyendung).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!phieutuyendungExists(id))
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


        // POST: api/phieutuyendungs
        [ResponseType(typeof(phieutuyendung))]
        public IHttpActionResult Postphieutuyendung([FromBody]phieutuyendung model)
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.phieutuyendungs.Add(phieu);
            db.SaveChanges();

            return Ok("{status:200,message: complete Save }");
        }

        // DELETE: api/phieutuyendungs/5
        [ResponseType(typeof(phieutuyendung))]
        public IHttpActionResult Deletephieutuyendung(int id)
        {
            phieutuyendung phieutuyendung = db.phieutuyendungs.Find(id);
            if (phieutuyendung == null)
            {
                return NotFound();
            }

            db.phieutuyendungs.Remove(phieutuyendung);
            db.SaveChanges();

            return Ok(phieutuyendung);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool phieutuyendungExists(int id)
        {
            return db.phieutuyendungs.Count(e => e.ptd_id == id) > 0;
        }
        public bool corverBoolMinh(int a)
        {
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}