using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Services.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace ExampleInvoiceApp.Services.Data.Repository
{
    public class InvoiceRepository : BaseRepository<Invoice>
    {
        public InvoiceRepository(DbSet<Invoice> dbSet) : base(dbSet)
        {
        }
        
        
    }
}