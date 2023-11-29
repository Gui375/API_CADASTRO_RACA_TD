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

            //if(ent.Curtiu == true)
            //{
            //    var curtidas = _curtidaRepositorio.Curtidas();
            //    foreach(var curtida in curtidas)
            //    {
            //        if(curtida.Curtiu == true && curtida.DestinoId == ent.AnimalId && curtida.AnimalId == ent.DestinoId)
            //        {
            //            Match match = new Match();
            //            match.UsuarioId1 = ent.AnimalId;
            //            match.UsuarioId2 = ent.DestinoId;
            //            match.Mensagens = null;
            //            _matchRepositorio.Adicionar(match);
            //            // adicionar retorno de confirmaçao do match
            //        }
            //    }
            //}
            
            return interagir;
        }
        public void Dispose()
        {
            _curtidaRepositorio.Dispose();
        }

        public List<Curtida> Curtidas()
        {
            throw new NotImplementedException();
        }
    }
}
