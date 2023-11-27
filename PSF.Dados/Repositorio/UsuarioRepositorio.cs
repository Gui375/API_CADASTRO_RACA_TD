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
        public Usuario BuscarPorId(int id)
        {
            return  Db.Usuario.Where(a => a.Id == id).AsNoTracking().FirstOrDefault();
        }

        public List<Usuario> Listar()
        {
            return  Db.Usuario.AsNoTracking().ToList();
        }
    }
}
