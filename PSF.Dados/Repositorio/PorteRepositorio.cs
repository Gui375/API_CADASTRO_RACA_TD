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
      
    }
}
