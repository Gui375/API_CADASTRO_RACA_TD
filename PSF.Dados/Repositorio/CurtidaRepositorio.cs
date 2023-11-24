using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.Repositorio
{
    public class CurtidaRepositorio : Repositorio<Curtida>
    {
        public CurtidaRepositorio(Contexto context) : base(context)
        {

        }
        
    }
}
