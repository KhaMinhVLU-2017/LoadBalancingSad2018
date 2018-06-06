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
using System.Web.Http.Description;
using API_Recruiment.Models;
using System.Web.Http.Cors;

namespace API_Recruiment.Controllers
{
    [EnableCors(origins: "http://localhost:53973,http://localhost:53689", headers: "*", methods: "*")]
    public class nhanviensController : ApiController
    {
        private SAD2018Entities db = new SAD2018Entities();

        // GET: api/nhanviens
        public IEnumerable<nhanvien> Getnhanviens()
        {
            List<nhanvien> meo = new List<nhanvien>();
            foreach(var item in db.nhanviens)
            {
                meo.Add(new nhanvien
                {
                    nv_id = item.nv_id,
                    nv_ten = item.nv_ten,
                    nv_diachi = item.nv_diachi,
                    nv_gioitinh = item.nv_gioitinh,
                    nv_ngaysinh = item.nv_ngaysinh,
                    nv_sdt = item.nv_sdt,
                    nv_tinhtrang = item.nv_tinhtrang,
                    pb_id = item.pb_id,
                    cvu_id = item.cvu_id,
                    tdhv_id = item.tdhv_id,
                    lg_bacluong = item.lg_bacluong,
                    tt_id = item.tt_id,
                    loai = item.loai,
                    nv_email = item.nv_email
                });
            }

            return meo;
        }

        // GET: api/nhanviens/5
        [ResponseType(typeof(nhanvien))]
        public async Task<IHttpActionResult> Getnhanvien(int id)
        {
            nhanvien nhanvien = await db.nhanviens.FindAsync(id);
            if (nhanvien == null)
            {
                return NotFound();
            }

            return Ok(nhanvien);
        }

        // PUT: api/nhanviens/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putnhanvien(int id, nhanvien nhanvien)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nhanvien.nv_id)
            {
                return BadRequest();
            }

            db.Entry(nhanvien).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!nhanvienExists(id))
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

        // POST: api/nhanviens
        [HttpPost]
        [ResponseType(typeof(phieutuyendung))]
        public async Task<IHttpActionResult> Postnhanvien([FromBody]phieutuyendung model)
        {
            phieutuyendung meo = db.phieutuyendungs.Find(model.ptd_id);
            nhanvien staff = new nhanvien();
            staff.nv_ten = meo.ptd_ten;
            staff.nv_ngaysinh = meo.ptd_ngaysinh;
            staff.nv_sdt = meo.ptd_sdt;
            staff.nv_gioitinh = meo.ptd_gioitinh;
            staff.cvu_id = int.Parse(meo.ptd_chucvu);
            staff.nv_email = meo.ptd_email;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.nhanviens.Add(staff);
            db.phieutuyendungs.Remove(meo);
            db.SaveChanges();
            return Ok("{status:200,message: complete Save }");
        }

        // DELETE: api/nhanviens/5
        [ResponseType(typeof(nhanvien))]
        public async Task<IHttpActionResult> Deletenhanvien(int id)
        {
            nhanvien nhanvien = await db.nhanviens.FindAsync(id);
            if (nhanvien == null)
            {
                return NotFound();
            }

            db.nhanviens.Remove(nhanvien);
            await db.SaveChangesAsync();

            return Ok(nhanvien);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool nhanvienExists(int id)
        {
            return db.nhanviens.Count(e => e.nv_id == id) > 0;
        }
    }
}