using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dados.Interface;
using PSF.Dominio;
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
        public AnimalRepositorio(ApplicationDbContext context) : base(context)
        {

        }

        public Animal BuscarPorId(int id)
        {
            return  Db.Animal.Where(a => a.Id == id).FirstOrDefault();
        }

        public  List<Animal> Listar()
        {
            return  Db.Animal.ToList();
        }
    }
}
