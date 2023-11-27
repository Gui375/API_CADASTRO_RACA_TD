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
        private  AnimalService _animal;

        public MensagemService(IMensagemService mensagemService)
        {
            _mensagemService = mensagemService;
        }

       

        public async Task<bool> AdicionarMensagem(Mensagem Men)
        {
            return await _mensagemService.AdicionarMensagem(Men);
        }



        public Task ChatPessoas(Mensagem pes)
        {
            throw new NotImplementedException(); //Não consegui fazer o link das pessoas
        }

        public async Task<List<Animal>> ListarAnimais()
        {
            return await _animal.Listar();
        }
    }
}
