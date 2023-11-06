using Microsoft.AspNetCore.Mvc;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;

namespace PSF.WebApp.Controllers
{
    public class RacaController : Controller
    {
        private Contexto db = new Contexto();

        public IActionResult Index()
        {
            var resultado = db.Raca
                .ToList();

            return View(resultado);
        }

        public IActionResult Inserir()
        {
            var ent = new Raca();
            return View(ent);
        }

        [HttpPost]
        public IActionResult InserirConfirmar(Raca ent)
        {
            db.Raca.Add(ent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int Raca_id)
        {
            var objeto = db
                .Raca
                .First(f => f.Id_Raca == Raca_id);

            db.Raca.Remove(objeto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }

   
}
