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
        public List<Raca> Listar();
        public Raca BuscarPorId(int id);
        public bool Adicionar(Raca ent);
        public bool Editar(Raca ent);
    }
}
