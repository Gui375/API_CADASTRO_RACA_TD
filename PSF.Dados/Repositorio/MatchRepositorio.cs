using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dados.Interface;
using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.Repositorio
{
    public class MatchRepositorio : Repositorio<Match>, IMatchRepositorio
    {
        public MatchRepositorio(Contexto context) : base(context)
        {
        }

        public List<Match> BuscarPorUsuarioId(int userId)
        {
            return Db.Match.AsNoTracking().Where(m => m.UsuarioId1 == userId).ToList();
        }

        public List<Match> Listar()
        {
            return Db.Match.AsNoTracking().ToList();
        }
    }
}
