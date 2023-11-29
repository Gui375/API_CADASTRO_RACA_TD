using Microsoft.AspNetCore.Mvc;
using PSF.Dominio.Entities;
using PSF.Servico.Interface;

namespace PSF.WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;
        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        //[HttpGet]
        //public List<Match> Listar()
        //{
        //    return _matchService.Listar();
        //} 

        //[HttpGet]
        //[Route("BuscarPorUsuarioId")]
        //public List<Match> BuscarPorUsuarioId(int userId)
        //{
        //    // configurar para pegar do usuario logado
        //    return _matchService.BuscarPorUsuarioId(userId);
        //} 
    }
}
