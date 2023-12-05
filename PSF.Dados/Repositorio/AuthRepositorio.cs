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
    public class AuthRepositorio : IAuthRepositorio
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public AuthRepositorio(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Usuario BuscarUsuario(string usuario)
        {
            return _applicationDbContext.Usuario.Where(u => u.Nome == usuario).FirstOrDefault();
        }

        public async Task<Usuario> Cadastrar(Usuario usuario)
        {
            _applicationDbContext.Usuario.Add(usuario);
            await _applicationDbContext.SaveChangesAsync();
            return usuario;
        }
    }
}
