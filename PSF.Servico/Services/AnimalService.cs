using PSF.Dados.Interface;
using PSF.Dominio.Entities;
using PSF.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Servico.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepositorio _animalRepositorio;
        public AnimalService(IAnimalRepositorio animalRepositorio)
        {
            _animalRepositorio = animalRepositorio;
        }

        public async Task<bool> Adicionar(Animal ent)
        {
            return await _animalRepositorio.Adicionar(ent);
        }

        public async Task<Animal> BuscarPorId(int id)
        {
            return await _animalRepositorio.BuscarPorId(id);
        }

        public async Task<bool> Editar(Animal ent)
        {
            return await _animalRepositorio.Atualizar(ent);
        }

        public async Task<List<Animal>> Listar()
        {
            return await _animalRepositorio.Listar();
        }
    }
}
