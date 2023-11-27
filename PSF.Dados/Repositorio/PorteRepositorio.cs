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
    public class PorteRepositorio : Repositorio<Porte>, IPorteRepositorio
    {
        public PorteRepositorio(Contexto context) : base(context)
        {

        }
        public Porte BuscarPorId(int id)
        {
            return Db.Portes.Where(a => a.Id == id).AsNoTracking().FirstOrDefault();
        }

        public List<Porte> Listar()
        {
            return Db.Portes.AsNoTracking().ToList();
        }
    }
}
