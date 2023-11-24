using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Servico.Interface
{
    public interface IAnimalService
    {
        public Task<List<Animal>> Listar();
        public Task<Animal> BuscarPorId(int id);
        public Task<bool> Adicionar(Animal ent);
        public Task<bool> Editar(Animal ent);
    }
}
