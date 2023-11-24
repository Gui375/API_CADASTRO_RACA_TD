using PSF.Dominio.Entities;


namespace PSF.Dados.Interface
{
    public interface IAuthRepositorio 
    {
        Task<Usuario> Cadastrar(Usuario usuario);
        Usuario BuscarUsuario(string usuario);
    }
}
