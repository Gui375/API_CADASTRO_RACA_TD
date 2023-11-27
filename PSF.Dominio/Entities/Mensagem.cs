using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dominio.Entities
{
    public class Mensagem : Entity
    {
        public string Conteudo { get; set; }
        public int MatchId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataHora { get; set; }
    }
}
