using System.Collections.Generic;
using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Common.Models.Requests;
using ExampleInvoiceApp.Services.Interfaces;

namespace ExampleInvoiceApp.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        public Task Create(CreateInvoiceRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Invoice> Read(int invoiceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Invoice>> ReadMany(IList<int> invoiceIds)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(UpdateInvoiceRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int invoiceId)
        {
            throw new System.NotImplementedException();
        }
    }
}