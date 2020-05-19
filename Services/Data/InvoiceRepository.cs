using System.Linq;
using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Services.Data.Base;
using ExampleInvoiceApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExampleInvoiceApp.Services.Data
{
    public class InvoiceRepository : BaseRepository<Invoice>
    {
        public InvoiceRepository(DbSet<Invoice> dbSet) : base(dbSet)
        {
        }
        

        public async Task Delete(int id)
        {
            DbSet.Remove(await DbSet.FindAsync(id));
        }
    }
}