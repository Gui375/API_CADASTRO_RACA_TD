using PSF.Dados.Interface;
using PSF.Dominio;
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
        private readonly IRacaRepositorio _racaRepositorio;
        private readonly IPorteRepositorio _porteRepositorio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public AnimalService(IAnimalRepositorio animalRepositorio, IRacaRepositorio racaRepositorio, IPorteRepositorio porteRepositorio, IUsuarioRepositorio usuarioRepositorio)
        {
            _animalRepositorio = animalRepositorio;
            _racaRepositorio = racaRepositorio;
            _porteRepositorio = porteRepositorio;
            _usuarioRepositorio = usuarioRepositorio;

        }

        public bool Adicionar(Animal ent)
        {
            var raca = _racaRepositorio.BuscarPorId(ent.RacaId);
            if (raca == null) ent.Raca = null;
            ent.Raca = raca;
            
            var porte = _porteRepositorio.BuscarPorId(ent.PorteId);
            if (porte == null) ent.Porte = null;
            ent.Porte = porte;

            var usuario = _usuarioRepositorio.BuscarPorId(ent.UsuarioId);
            if (usuario == null) ent.Usuario = null;
            ent.Usuario = usuario;

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
