using Microsoft.EntityFrameworkCore;
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
    public class AnimalRepositorio : Repositorio<Animal>, IAnimalRepositorio
    {
        public AnimalRepositorio(Contexto context) : base(context)
        {

        }

        public async Task<Animal> BuscarPorId(int id)
        {
            return await Db.Animal.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Animal>> Listar()
        {
            return await Db.Animal.ToListAsync();
        }
    }
}
