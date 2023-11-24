using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.Interface
{
    public interface IRepositorio<TEntity> : IDisposable where TEntity : Entity
    {
        Task<bool> Adicionar(TEntity entity);
        Task<bool> Atualizar(TEntity entity);
        Task<bool> ExclusaoLogica(TEntity entity);
        Task<bool> Remover(int id);

    }
}
