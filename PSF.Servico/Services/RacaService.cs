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

        public async Task<bool> Adicionar(Raca ent)
        {
            return await _racaRepositorio.Adicionar(ent);
        }

        public Task<Raca> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Editar(Raca ent)
        {
            throw new NotImplementedException();
        }

        public Task<List<Raca>> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
