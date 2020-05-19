using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExampleInvoiceApp.Services.Data.Repository.Base
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly DbSet<T> DbSet; //protected to allow access id methods will be override

        protected BaseRepository(DbSet<T> dbSet)
        {
            DbSet = dbSet;
        }
        
        public virtual async Task Create(T item)
        {
            await DbSet.AddAsync(item);
        }

        public virtual async Task<T> Read(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task Update(T item)
        {
            DbSet.Update(item);
        }

        public virtual async Task Delete(T item)
        {
            DbSet.Remove(item);
        }
        
        public virtual async Task Delete(int id)
        {
            DbSet.Remove(await DbSet.FindAsync(id));
        }

        public virtual async Task<List<T>> ReadAll()
        {
            return await DbSet.ToListAsync();
        }
    }
}