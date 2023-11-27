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
    public class RacaRepositorio : Repositorio<Raca>, IRacaRepositorio
    {
        public RacaRepositorio(Contexto context) : base(context)
        {

        }
        public async Task<Raca> BuscarPorId(int id)
        {
            return await Db.Raca.Where(a => a.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<List<Raca>> Listar()
        {
            return await Db.Raca.AsNoTracking().ToListAsync();
        }

    }
}
