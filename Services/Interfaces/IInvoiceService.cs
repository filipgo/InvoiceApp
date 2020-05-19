using System.Collections.Generic;
using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;

namespace ExampleInvoiceApp.Services.Interfaces
{
    public interface IInvoiceService
    {
        Task Create(Invoice invoice);

        Task<Invoice> Read(int invoiceId);

        Task<IList<Invoice>> ReadMany(IList<int> invoiceIds);

        Task<List<Invoice>> ReadAll();
        
        Task Update(Invoice invoice);

        Task Delete(int invoiceId);

    }
}