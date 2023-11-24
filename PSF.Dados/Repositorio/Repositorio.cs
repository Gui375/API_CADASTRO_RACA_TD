using Microsoft.EntityFrameworkCore;
using PSF.Dados.EntityFramework;
using PSF.Dados.Interface;
using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.Repositorio
{
    public abstract class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : Entity, new()
    {

        protected readonly Contexto Db;
        protected readonly DbSet<TEntity> DbSet;


        protected Repositorio(Contexto db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> ObterPorId(int id)
        {
            try
            {
                return await DbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }


        public virtual async Task<bool> Adicionar(TEntity entity)
        {
            try
            {
                DbSet.Add(entity);
                await Db.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual async Task<bool> Atualizar(TEntity entity)
        {
            try
            {
                DbSet.Update(entity);
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual async Task<bool> Remover(int id)
        {
            try
            {
                DbSet.Remove(new TEntity { Id = id });
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual async Task<bool> ExclusaoLogica(TEntity entity)
        {
            entity.Ativo = false;
            try
            {
                DbSet.Update(entity);
                await SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
