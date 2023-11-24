using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dominio.Entities
{
    public class Animal : Entity
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        public int PorteId { get; set; }
        public Porte Porte { get; set; }
        public int RacaId { get; set; }
        public Raca Raca { get; set; }
        public DateTime DataNascimento { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
