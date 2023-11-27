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

        public bool Adicionar(Animal ent)
        {
            return _animalRepositorio.Adicionar(ent);
        }

        public Animal BuscarPorId(int id)
        {
            return _animalRepositorio.BuscarPorId(id);
        }

        public bool Editar(Animal ent)
        {
            return _animalRepositorio.Atualizar(ent);
        }

        public  List<Animal> Listar()
        {
            return _animalRepositorio.Listar();
        }
    }
}
