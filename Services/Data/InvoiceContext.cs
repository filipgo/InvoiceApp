using ExampleInvoiceApp.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleInvoiceApp.Services.Data
{
    public class InvoiceContext : DbContext
    {
        public DbSet<Invoice> InvoiceSet { get; set; }

        public DbSet<InvoiceRow> InvoiceRowSet { get; set; } 
        
        public DbSet<Client> ClientSet { get; set; }
        
    }
}