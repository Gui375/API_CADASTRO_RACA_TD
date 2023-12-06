using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;
using PSF.Servico.Interface;
using PSF.Servico.Services;

namespace PSF.WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PorteController : Controller
    {
        private readonly IPorteService _porteService;

        public PorteController(IPorteService porteService)
        {
            _porteService = porteService;
        }

        [HttpGet]
        public Porte Buscar(int id)
        {
            return _porteService.BuscarPorId(id);
        }
        
        [HttpPost]
        [Route("AdicionarPorte")]
        public ActionResult<bool> Adicionar(Porte ent)
        {
            var result = _porteService.Adicionar(ent);
            return Ok(result);
        }
        [HttpGet]
        [Route("Listar")]
        public ActionResult<List<Porte>> Listar()
        {
            var result = _porteService.Listar();
            return Ok(result);
        }

        public IActionResult Index()
        {
            var resultado = _porteService.Listar();
            return View(resultado);
        }

        [Route("Inserir")]
        public IActionResult Inserir()
        {
            var ent = new Porte();
            return View(ent);
        }

        [HttpPost]
        public IActionResult InserirConfirmar(Porte ent)
        {
            _porteService.Adicionar(ent);
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int id)
        {
            var objeto = _porteService.BuscarPorId(id);
            objeto.Ativo = false;

            _porteService.Editar(objeto);

            return RedirectToAction("Index");
        }

    }


}
