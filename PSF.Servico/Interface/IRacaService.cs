using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Servico.Interface
{
    public interface IRacaService : IDisposable
    {
        public Task<List<Raca>> Listar();
        public Task<Raca> BuscarPorId(int id);
        public Task<bool> Adicionar(Raca ent);
        public Task<bool> Editar(Raca ent);
    }
}
