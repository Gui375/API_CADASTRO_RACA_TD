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
    public class PorteRepositorio : Repositorio<Porte>, IPorteRepositorio
    {
        public PorteRepositorio(Contexto context) : base(context)
        {

        }
        public async Task<Porte> BuscarPorId(int id)
        {
            return await Db.Portes.Where(a => a.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<List<Porte>> Listar()
        {
            return await Db.Portes.AsNoTracking().ToListAsync();
        }
    }
}
