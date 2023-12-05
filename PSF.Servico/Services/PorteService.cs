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
    public class PorteService : IPorteService
    {
        private readonly IPorteRepositorio _porteRepositorio;
        public PorteService(IPorteRepositorio porteRepositorio)
        {
            _porteRepositorio = porteRepositorio;
        }
        public bool Adicionar(Porte ent)
        {
            return _porteRepositorio.Adicionar(ent);
        }

        public Porte BuscarPorId(int id)
        {
            return _porteRepositorio.BuscarPorId(id);
        }

        public void Dispose()
        {
            _porteRepositorio.Dispose();
        }

        public bool Editar(Porte ent)
        {
            throw new NotImplementedException();
        }

        public List<Porte> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
