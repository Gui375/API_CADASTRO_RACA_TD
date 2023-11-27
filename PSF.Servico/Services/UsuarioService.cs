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
        public bool Adicionar(Usuario ent)
        {
            return _usuarioRepositorio.Adicionar(ent);
        }

        public Usuario BuscarPorId(int id)
        {
            return _usuarioRepositorio.BuscarPorId(id);
        }

        public void Dispose()
        {
            _usuarioRepositorio.Dispose();
        }

        public bool Editar(Usuario ent)
        {
            return _usuarioRepositorio.Atualizar(ent);
        }

        public List<Usuario> Listar()
        {
            return _usuarioRepositorio.Listar();
        }
    }
}
