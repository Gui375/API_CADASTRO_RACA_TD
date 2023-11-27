using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.Interface
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        public Task<List<Usuario>> Listar();
        public Task<Usuario> BuscarPorId(int id);
    }
}
