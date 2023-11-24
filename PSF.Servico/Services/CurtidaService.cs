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
    public class CurtidaService : ICurtidaService
    {
        private readonly ICurtidaRepositorio _curtidaRepositorio;
        public CurtidaService(ICurtidaRepositorio curtidaRepositorio)
        {
            _curtidaRepositorio = curtidaRepositorio;
        }

        public async Task<bool> Interacao(Curtida ent)
        {
            var interagir = await _curtidaRepositorio.Adicionar(ent);
            
            return interagir;
        }
        public void Dispose()
        {
            _curtidaRepositorio.Dispose();
        }
    }
}
