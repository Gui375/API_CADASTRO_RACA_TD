using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.Interface
{
    public interface IRacaRepositorio : IRepositorio<Raca>
    {
        public List<Raca> Listar();
        public Raca BuscarPorId(int id);
    }
}
