using Microsoft.AspNetCore.Mvc;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;

namespace PSF.WebApp.Controllers
{
    public class UsuarioController : Controller
    {
       
            private Contexto db = new Contexto();

            public IActionResult Index()
            {
                var resultado = db.usuarios.ToList();
                return View(resultado);
            }

            public IActionResult Inserir()
            {
                var ent = new Usuario();
                return View(ent);
            }

            [HttpPost]
            public IActionResult InserirConfirmar(Usuario ent)
            {
                db.usuarios.Add(ent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            public IActionResult Excluir(int id)
            {
                var objeto = db
                    .usuarios
                    .First(f => f.Id == id);

                db.usuarios.Remove(objeto);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

        
    }
}
