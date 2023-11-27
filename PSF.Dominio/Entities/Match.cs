using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dominio.Entities
{
    public class Match : Entity
    {
        public int UsuarioId1 { get; set; }
        public int UsuarioId2 { get; set; }
        public List<Mensagem> Mensagens { get; set; }
    }
}
