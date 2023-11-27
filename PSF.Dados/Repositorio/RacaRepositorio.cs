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
    public class RacaRepositorio : Repositorio<Raca>, IRacaRepositorio
    {
        public RacaRepositorio(Contexto context) : base(context)
        {

        }
        public Raca BuscarPorId(int id)
        {
            return  Db.Raca.Where(a => a.Id == id).AsNoTracking().FirstOrDefault();
        }

        public List<Raca> Listar()
        {
            return Db.Raca.AsNoTracking().ToList();
        }

    }
}
