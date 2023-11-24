using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dominio.Entities
{
    public class Curtida : Entity
    {
        public int AnimalId { get; set; }
        public int DestinoId { get; set; }
        // se curtiu for falso é porque ele descurtiu
        public bool Curtiu { get; set; }
    }
}
