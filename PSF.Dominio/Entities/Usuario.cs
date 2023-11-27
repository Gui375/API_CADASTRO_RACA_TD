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
        public string Senha { get; set; }
        public List<Animal> Animais { get; set; }
        public List<Match> Matchs { get; set; }
        public bool Ativo { get; set; }

    }
}
