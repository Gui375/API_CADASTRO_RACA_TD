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
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(Contexto context) : base(context)
        {

        }
        public async Task<Usuario> BuscarPorId(int id)
        {
            return await Db.Usuario.Where(a => a.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<List<Usuario>> Listar()
        {
            return await Db.Usuario.AsNoTracking().ToListAsync();
        }
    }
}
