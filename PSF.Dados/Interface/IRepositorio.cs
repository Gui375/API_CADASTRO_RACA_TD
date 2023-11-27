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
        bool Adicionar(TEntity entity);
        bool Atualizar(TEntity entity);
        bool ExclusaoLogica(TEntity entity);
        bool Remover(int id);

    }
}
