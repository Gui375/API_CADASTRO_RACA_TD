using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;
using PSF.Servico.Interface;

namespace PSF.WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RacaController : Controller
    {
        private readonly IRacaService _racaService;

        public RacaController(IRacaService racaService)
        {
            _racaService = racaService;
        }

        public IActionResult Index()
        {
            var resultado = _racaService.Listar();
            return View(resultado);
        }
        [Route("Inserir")]
        public IActionResult Inserir()
        {
            var ent = new Raca();
            return View(ent);
        }

        [HttpPost]
        public IActionResult InserirConfirmar(Raca ent)
        {
            _racaService.Adicionar(ent);
            return RedirectToAction("Index");
        }

        //public IActionResult Excluir(int id)
        //{
        //    var objeto = _racaService.BuscarPorId(id);
        //    objeto.Ativo = false;

        //    _racaService.Editar(objeto);

        //    return RedirectToAction("Index");
        //}

    }

   
}
