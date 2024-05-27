using Microsoft.AspNetCore.Mvc;
using T2_QUISOCALA_KAREN.Datos;
using T2_QUISOCALA_KAREN.Models;

namespace T2_QUISOCALA_KAREN.Controllers
{
    public class DistribuidorController : Controller
    {
        public readonly ApplicationDbContext _db;
        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View(lista);
        }
        public IActionResult DistribuidoresDelPeru()
        {
            return View();
        }
        public IActionResult DistribuidoresDelMundo()
        {
            return View();
        }
        //Agregar
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Agregar(Distribuidor distribuidor)
        {
            if (ModelState.IsValid) 
            {
                _db.Distribuidor.Add(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(distribuidor);   
        }
        //Editar
        public IActionResult Editar(int? Id)
        {
            if (Id==null || Id==0)
            {
                return NotFound();
            }
            var obj = _db.Distribuidor.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Distribuidor distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.Distribuidor.Update(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(distribuidor);
        }
        //Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Distribuidor.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Distribuidor distribuidor)
        {
            if (distribuidor==null)
            {
                return NotFound();
            }
            _db.Distribuidor.Remove(distribuidor);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
