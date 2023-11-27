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
        public List<Usuario> Listar();
        public Usuario BuscarPorId(int id);
    }
}
