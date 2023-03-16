using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageBE.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageBE.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        DataContext db = new DataContext();
        //Get metoda za cijelu listu studenata
        [HttpGet]
        public IActionResult sviStudenti()
        {
            List<Studenti> listaStudenata = db.Studentis.OrderByDescending(x => x.studentId).ToList();
            return Ok(listaStudenata);
        }

        [HttpGet]
        public IActionResult vrsteStatusaStudenta()
        {
            List<StatusStudenta> listStatusa = db.statusStudentas.OrderBy(x => x.statusId).ToList();
            return Ok(listStatusa);
        }

        //Get metoda za studenta po IDu
        [HttpGet]
        public IActionResult studentPoIDu(int id)
        {
            List<Studenti> student = db.Studentis.Where(x => x.studentId == id).ToList();
            return Ok(student);
        }

        //Post metoda za upis novog studenta
        [HttpPost]
        public IActionResult upisStudenta([FromBody] Studenti podaci)
        {
            db.Add(podaci);
            db.SaveChanges();
            return Ok(podaci);
        }

        //Update informacija postojećeg studenta (putem POST metode)
        [HttpPost]
        public IActionResult updateStudenta(int id, int brojindexa, string ime, string prezime, int godina, int statusid)
        {
            Studenti student = db.Studentis.Where(a => a.studentId == id).FirstOrDefault();
            if (student != null)
            {
                student.brojIndexa = (brojindexa != null) ? brojindexa : student.brojIndexa;
                student.Ime = (ime != null) ? ime : student.Ime;
                student.Prezime = (prezime != null) ? prezime : student.Prezime;
                student.Godina = (godina != null) ? godina : student.Godina;
                student.statusId = (statusid != null) ? statusid : student.statusId;

                db.SaveChanges();
            }
            else
            {
                return NotFound($"Student sa id {id} nije pronadjena");
            }

            return Ok(student);
        }
        //Delete metoda za brisanje studenta po IDu
        [HttpDelete("{id:int}")]
        public IActionResult obrisiStudenta(int id)
        {
            Studenti student = db.Studentis.Where(x => x.studentId == id).FirstOrDefault();
            if (student == null)
            {
                return NotFound($"Student pod ID = {id} nije pronađen");
            }
            else
            {
                db.Remove(student);
                db.SaveChanges();
            }
            return Ok($"Student pod ID = {id} je obrisan");
        }
    }
}
