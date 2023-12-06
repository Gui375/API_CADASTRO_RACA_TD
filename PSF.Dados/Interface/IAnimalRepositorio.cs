using PSF.Dominio;
using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.Interface
{
    public interface IAnimalRepositorio : IRepositorio<Animal>
    {
        public List<Animal> Listar();
        public Animal BuscarPorId(int id);
    }
}
