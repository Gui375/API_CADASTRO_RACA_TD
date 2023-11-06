using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dominio.Entities
{
    public class Raca : Entity
    {
  
        public string NomeRaca { get; set; }
        public int Tamanho { get; set; }
        public char Porte { get; set; }
    }
}
