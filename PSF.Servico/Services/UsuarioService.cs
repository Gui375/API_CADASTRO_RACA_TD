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
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public Task<bool> Adicionar(Usuario ent)
        {
            return _usuarioRepositorio.Adicionar(ent);
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _usuarioRepositorio.BuscarPorId(id);
        }

        public void Dispose()
        {
            _usuarioRepositorio.Dispose();
        }

        public async Task<bool> Editar(Usuario ent)
        {
            return await _usuarioRepositorio.Atualizar(ent);
        }

        public async Task<List<Usuario>> Listar()
        {
            return await _usuarioRepositorio.Listar();
        }
    }
}
