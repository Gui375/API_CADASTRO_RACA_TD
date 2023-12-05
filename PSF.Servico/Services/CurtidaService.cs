using PSF.Dados.Interface;
using PSF.Dominio.Entities;
using PSF.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Servico.Services
{
    public class CurtidaService : ICurtidaService
    {
        private readonly ICurtidaRepositorio _curtidaRepositorio;
        private readonly IMatchRepositorio _matchRepositorio;
        public CurtidaService(ICurtidaRepositorio curtidaRepositorio, IMatchRepositorio matchRepositorio)
        {
            _curtidaRepositorio = curtidaRepositorio;
            _matchRepositorio = matchRepositorio;
        }

        public bool Interacao(Curtida ent)
        {
            var interagir = _curtidaRepositorio.Adicionar(ent);
            if(interagir == true )
            {
                if (ent.Curtiu == true)
                {
                    var curtidas = _curtidaRepositorio.Curtidas();
                    foreach (var curtida in curtidas)
                    {
                        if (curtida.Curtiu == true && ent.Curtiu == true && curtida.DestinoId == ent.AnimalId && curtida.AnimalId == ent.DestinoId)
                        {
                            Match match = new Match();
                            match.Cachorro1 = ent.AnimalId;
                            match.Cachorro2 = ent.DestinoId;
                            match.Mensagens = null;
                            _matchRepositorio.Adicionar(match);
                            //retorna true apenas se der match
                            return true;
                        }
                    }
                }

                return false;
            }
            return false;
        }
        public void Dispose()
        {
            _curtidaRepositorio.Dispose();
        }

        public List<Curtida> Curtidas()
        {
            return _curtidaRepositorio.Curtidas();
        }
    }
}
