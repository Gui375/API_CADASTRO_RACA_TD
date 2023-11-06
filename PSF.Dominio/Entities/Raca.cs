using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dominio.Entities
{
    public class Raca
    {
        public Raca()
        {
            //DataNascimento = DateTime.Now;
        }

        public int Id_Raca { get; set; }
        public string Nome_Raca { get; set; }
        public int Tamanho { get; set; }
        public char Porte { get; set; }
    }
}
