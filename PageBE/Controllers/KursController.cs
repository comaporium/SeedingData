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
    public class KursController : ControllerBase
    {
        DataContext db = new DataContext();
        //Get za sve kurseve
        [HttpGet]
        public IActionResult sviKursevi()
        {
            List<Kurs> kursevi = db.Kurs.OrderBy(x => x.kursId).ToList();
            return Ok(kursevi);
        }
        //Get za sve ucesnike svih kurseva
        [HttpGet]
        public IActionResult sviUcesniciKurseva()
        {
            List<KursStudenta> kursevi = db.KursStudentas.OrderBy(x => x.kursStudentaId).ToList();
            return Ok(kursevi);
        }
        //Post metoda za dodavanje novog kursa
        [HttpPost]
        public IActionResult dodajKurs([FromBody] Kurs podaci)
        {
            db.Add(podaci);
            db.SaveChanges();
            return Ok(podaci);
        }
        //Post metoda za upis novog studenta na kurs
        [HttpPost]
        public IActionResult upisStudentaNaKurs([FromBody] KursStudenta podaci)
        {
            db.Add(podaci);
            db.SaveChanges();
            return Ok(podaci);
        }

    }
}
