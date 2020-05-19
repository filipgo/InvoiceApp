using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleInvoiceApp.Services.Data.Base
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly DbSet<T> DbSet;

        protected BaseRepository(DbSet<T> dbSet)
        {
            DbSet = dbSet;
        }
        
        public async Task Create(T item)
        {
            await DbSet.AddAsync(item);
        }

        public virtual async Task<T> Read(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task Update(T item)
        {
            DbSet.Update(item);
        }

        public async Task Delete(T item)
        {
            DbSet.Remove(item);
        }
    }
}