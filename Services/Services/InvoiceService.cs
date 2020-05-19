using System.Collections.Generic;
using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Services.Interfaces;

namespace ExampleInvoiceApp.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Invoice> _invoiceRepository;

        public InvoiceService(IRepository<Invoice> invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        
        public async Task Create(Invoice invoice)
        {
            await this.CalcSum(invoice).ConfigureAwait(false);
            await _invoiceRepository.Create(invoice);
        }

        public async Task<Invoice> Read(int invoiceId)
        {
            return await _invoiceRepository.Read(invoiceId);
        }

        public async Task<IList<Invoice>> ReadMany(IList<int> invoiceIds)
        {
            var result = new List<Invoice>();

            foreach (var id in invoiceIds)
            {
                result.Add(await _invoiceRepository.Read(id));
            }

            return result;
        }

        public async Task Update(Invoice invoice)
        {
            await _invoiceRepository.Update(invoice);
        }

        public async Task Delete(int invoiceId)
        {
            await _invoiceRepository.Delete(invoiceId);
        }

        private async Task<Invoice> CalcSum(Invoice invoice)
        {
            double net = 0;
            double gross = 0;
            
            foreach (var row in invoice.InvoiceRows)
            {
                net += row.UnitNetPrice * row.Quantity;
                gross += (row.UnitNetPrice * row.Quantity) * (((double)row.VatRate + 100) / 100);
            }

            invoice.NetSum = net;
            invoice.GrossSum = gross;

            return invoice;
        }
    }

}