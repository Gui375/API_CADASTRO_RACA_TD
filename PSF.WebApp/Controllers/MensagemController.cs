using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;
using PSF.Servico.Interface;

namespace PSF.WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MensagemController : Controller
    {
        private readonly IAnimalService _animalService;
        private readonly IMensagemService _mensagemService;
        private readonly ICurtidaService _curtidaService;

        public MensagemController(IAnimalService animalService, IMensagemService mensagemService, ICurtidaService curtidaService)
        {
            _animalService = animalService;
            _mensagemService = mensagemService;
            _curtidaService = curtidaService;
        }


        [HttpPost]
        public ActionResult<Mensagem> AdicionarMensagem(Mensagem men)
        {
            if (men == null || !ModelState.IsValid)
                return BadRequest(BadRequest());

            var result =  _mensagemService.AdicionarMensagem(men);

            if (result == false) return BadRequest();

            return Ok(men);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
