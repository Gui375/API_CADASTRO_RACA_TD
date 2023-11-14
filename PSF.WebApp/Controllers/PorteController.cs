using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;

namespace PSF.WebApp.Controllers
{
    public class PorteController : Controller
    {
        private Contexto db = new Contexto();

        public IActionResult Index()
        {
            var resultado = db.Portes.ToList();
            return View(resultado);
        }

        public IActionResult Inserir()
        {
            var ent = new Porte();
            return View(ent);
        }

        [HttpPost]
        public IActionResult InserirConfirmar(Porte ent)
        {
            db.Portes.Add(ent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int id)
        {
            var objeto = db
                .Portes
                .First(f => f.Id == id);

            db.Portes.Remove(objeto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }


}
