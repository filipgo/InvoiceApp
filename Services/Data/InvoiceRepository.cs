using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExampleInvoiceApp.Services.Data
{
    public class InvoiceRepository : IRepository<Invoice>
    {
        private readonly DbContext _context;


        public Task Create(Invoice item)
        {
            throw new System.NotImplementedException();
        }

        public Task<Invoice> Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Invoice item)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}