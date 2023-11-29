using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Servico.Interface
{
    public interface IMatchService : IDisposable
    {
        public List<Match> Listar();
        public List<Match> BuscarPorUsuarioId(int userId);
        public bool Adicionar(Match ent);
    }
}
