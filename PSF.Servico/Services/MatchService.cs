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
        private readonly IMatchService _matchService;
        public MatchService(IMatchService matchService)
        {
            _matchService  = matchService;
        }
        public bool Adicionar(Match ent)
        {
            return _matchService.Adicionar(ent);
        }

        public List<Match> BuscarPorUsuarioId(int userId)
        {
            return _matchService.BuscarPorUsuarioId(userId);
        }

        public List<Match> Listar()
        {
            return _matchService.Listar();
        }
    }
}
