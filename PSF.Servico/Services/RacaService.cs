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
    public class RacaService : IRacaService
    {
        private readonly IRacaRepositorio _racaRepositorio;

        public RacaService(IRacaRepositorio racaRepositorio)
        {
            _racaRepositorio = racaRepositorio;
        }

        public bool Adicionar(Raca ent)
        {
            return _racaRepositorio.Adicionar(ent);
        }

        public Raca BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _racaRepositorio.Dispose();
        }

        public bool Editar(Raca ent)
        {
            throw new NotImplementedException();
        }

        public List<Raca> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
