using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Servico.Interface
{
    public interface IUsuarioService : IDisposable
    {
        public Task<List<Usuario>> Listar();
        public Task<Usuario> BuscarPorId(int id);
        public Task<bool> Adicionar(Usuario ent);
        public Task<bool> Editar(Usuario ent);
    }
}
