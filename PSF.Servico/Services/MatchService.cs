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
    public class MatchService : IMatchService
    {
        private readonly IMatchRepositorio _matchRepositorio;
        public MatchService(IMatchRepositorio matchRepositorio)
        {
            _matchRepositorio = matchRepositorio;
        }
        public bool Adicionar(Match ent)
        {
            return _matchRepositorio.Adicionar(ent);
        }

        public List<Match> BuscarPorUsuarioId(int userId)
        {
            return _matchRepositorio.BuscarPorUsuarioId(userId);
        }

        public void Dispose()
        {
            _matchRepositorio.Dispose();    
        }

        public List<Match> Listar()
        {
            return _matchRepositorio.Listar();
        }
    }
}
