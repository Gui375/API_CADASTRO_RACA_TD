using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;
using PSF.Servico.Interface;

namespace PSF.WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalController : Controller
    {
        private readonly ICurtidaService _curtidaService;
        private readonly IAnimalService _animalService;

        public AnimalController(ICurtidaService curtidaService, IAnimalService animalService)
        {
            _curtidaService = curtidaService;
            _animalService = animalService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Animal>>> Buscar()
        {
            var objeto = await _animalService.Listar();

            return Ok(objeto);
        }

        [HttpPost]
        public async Task<ActionResult<Animal>> Adicionar(Animal ent)
        {
            if(ent == null || !ModelState.IsValid)
                return BadRequest(BadRequest());

            var result = await _animalService.Adicionar(ent);

            return Ok(ent);
        }
        
        [HttpPut]
        public async Task<ActionResult<Animal>> Editar(Animal ent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var objeto = await _animalService.BuscarPorId(ent.Id);
            if(objeto == null)
            {
                return BadRequest();
            }
            await _animalService.Editar(objeto);


            return Ok(ent);
        }
        
        [HttpPost]
        [Route("Curtida")]
        public async Task<ActionResult<bool>> Interagir(Curtida curtida)
        {

            if (!ModelState.IsValid)
                return BadRequest(BadRequest());

            var result = await _curtidaService.Interacao(curtida);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<bool> Excluir(int id)
        {
            var result = await _animalService.BuscarPorId(id);

            result.Ativo = false;

            await _animalService.Editar(result);

            return true;
        }

    }


}
