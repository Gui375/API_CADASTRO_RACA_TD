using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Servico.Interface
{
    public interface IAuthService
    {
        Task<Usuario> Cadastrar(Usuario usuario);
        Usuario BuscarUsuario(string usuario);
    }
}
