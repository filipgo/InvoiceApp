using System.Collections.Generic;
using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Common.Models.Requests;

namespace ExampleInvoiceApp.Services.Interfaces
{
    public interface IInvoiceService
    {
        Task Create(CreateInvoiceRequest request);

        Task<Invoice> Read(int invoiceId);

        Task<IList<Invoice>> ReadMany(IList<int> invoiceIds);
        
        Task Update(UpdateInvoiceRequest request);

        Task Delete(int invoiceId);

    }
}