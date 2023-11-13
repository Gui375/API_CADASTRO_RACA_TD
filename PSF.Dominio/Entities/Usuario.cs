using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dominio.Entities
{
    public class Usuario : Entity
    {
        public string Nome{ get; set; }
        public char ATIVO { get; set; }

    }
}
