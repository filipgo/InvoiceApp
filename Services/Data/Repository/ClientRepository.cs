using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Services.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace ExampleInvoiceApp.Services.Data.Repository
{
    public class ClientRepository : BaseRepository<Client>
    {
        public ClientRepository(DbSet<Client> dbSet) : base(dbSet)
        {
        }
    }
}