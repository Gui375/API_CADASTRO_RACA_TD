using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;

namespace PSF.WebApp.Controllers
{
    public class AnimalController : Controller
    {
        private Contexto db = new Contexto();

        [HttpGet]
        public ActionResult<List<Animal>> Buscar()
        {
            var objeto = db
                .Animal
                .ToList();

            return Ok(objeto);
        }

        [HttpPost]
        public ActionResult<Animal> Adicionar(Animal ent)
        {
            if(ent == null)
                return BadRequest(BadRequest());
            db.Animal.Add(ent);
            db.SaveChanges();
            return Ok(ent);
        }
        
        [HttpPut]
        public ActionResult<Animal> Editar(Animal ent)
        {
            var objeto = db
                .Animal
                .First(f => f.Id == ent.Id);
            if (objeto == null || ent == null)
                return BadRequest(BadRequest());

            objeto = ent;
            db.Animal.Add(ent);
            db.SaveChanges();
            return Ok(ent);
        }

        [HttpDelete]
        public bool Excluir(int id)
        {
            var objeto = db
                .Portes
                .First(f => f.Id == id);

            db.Portes.Remove(objeto);
            db.SaveChanges();

            return true;
        }

    }


}
