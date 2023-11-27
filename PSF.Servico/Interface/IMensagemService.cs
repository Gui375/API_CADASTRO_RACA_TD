using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Servico.Interface
{
    public interface IMensagemService
    {
        public Task<List<Animal>> ListarAnimais();
        public Task<bool> AdicionarMensagem(Mensagem Men);

        //public Task<bool> AdicionarMensagem(string conteudo);
        public Task ChatPessoas(Mensagem pes);  //Responsavel por linkar quem curtiu e quem foi curtido

    }
}
