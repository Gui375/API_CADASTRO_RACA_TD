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

        protected readonly ApplicationDbContext Db;
        protected readonly DbSet<TEntity> DbSet;


        protected Repositorio(ApplicationDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate).ToList();
        }

        public virtual TEntity ObterPorId(int id)
        {
            try
            {
                return DbSet.Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public virtual List<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }


        public virtual bool Adicionar(TEntity entity)
        {
            try
            {
                DbSet.Add(entity);
                Db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual bool Atualizar(TEntity entity)
        {
            try
            {
                DbSet.Update(entity);
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual bool Remover(int id)
        {
            try
            {
                DbSet.Remove(new TEntity { Id = id });
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual bool ExclusaoLogica(TEntity entity)
        {
            entity.Ativo = false;
            try
            {
                DbSet.Update(entity);
                SaveChanges();
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
