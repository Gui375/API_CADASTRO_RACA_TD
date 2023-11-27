using PSF.Dados.Interface;
using PSF.Dados.Repositorio;
using PSF.Dominio.Entities;
using PSF.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PSF.Servico.Services
{
    internal class MensagemService : IMensagemService
    {
        private readonly IMensagemService _mensagemService;

        public MensagemService(IMensagemService mensagemService)
        {
            _mensagemService = mensagemService;
        }

       

        public bool AdicionarMensagem(Mensagem Men)
        {
            return _mensagemService.AdicionarMensagem(Men);
        }

        

      
    }
}
