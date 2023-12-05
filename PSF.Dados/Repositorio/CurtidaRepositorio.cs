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
    public class CurtidaRepositorio : Repositorio<Curtida>, ICurtidaRepositorio
    {
        public CurtidaRepositorio(ApplicationDbContext context) : base(context)
        {

        }

        public List<Curtida> Curtidas()
        {
            return Db.Curtida.ToList();
        }
    }
}
