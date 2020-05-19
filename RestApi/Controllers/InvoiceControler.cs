using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Common.Models.Requests;
using ExampleInvoiceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExampleInvoiceApp.RestApi.Controllers
{
    [Produces("application/json")]
    [Route("api/invoice")]
    public class InvoiceController : ControllerBase
    {
        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        private readonly IInvoiceService _invoiceService;

        [HttpPost]
        public async Task<IActionResult> Create(Invoice invoice)
        {
            await _invoiceService.Create(invoice);
            
            throw new NotImplementedException();
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(UpdateInvoiceRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<ActionResult<IList<Invoice>>> GetAll()
        {
            var result =  new List<Invoice>();
            
            result.Add(await GetTestInvoice().ConfigureAwait(false));
            result.Add(await GetTestInvoice().ConfigureAwait(false));
            result.Add(await GetTestInvoice().ConfigureAwait(false));
            result.Add(await GetTestInvoice().ConfigureAwait(false));
            result.Add(await GetTestInvoice().ConfigureAwait(false));

            return result;
        }
        
        [HttpGet("{invoiceId}")]
        public async Task<ActionResult<Invoice>> Read(int invoiceId)
        {
            return await GetTestInvoice().ConfigureAwait(false);
        }
        
        [HttpDelete("{invoiceId}")]
        public async Task<IActionResult> Delete()
        {
            throw new NotImplementedException();
        }

        private async Task<Invoice> GetTestInvoice()
        {
            var result = new Invoice
            {
                Client = new Client
                {
                    Address  = new Address
                    {
                        Street = "Sezamkowa",
                        BuildingNumber = "235a",
                        FlatNumber = "32",
                        City = "Warszawa",
                        Country = "Polska",
                        PostCode = 00500
                    },
                    TaxId = "1234567890",
                    Id = 1
                },
                Id = 1,
                IsPaid = true,
                SellDate = DateTime.Now,
                IssueDate = DateTime.Now,
                Month = DateTime.Now.Month,
                Number = 1,
                InvoiceRows = new List<InvoiceRow>
                {
                    new InvoiceRow
                    {
                        Name = "Piwo",
                        Quantity = 123,
                        UnitNetPrice = 3.29,
                        VatRate = 8
                    },
                    new InvoiceRow
                    {
                        Name = "Chleb",
                        Quantity = 123,
                        UnitNetPrice = 5.67,
                        VatRate = 5
                    }
                },
            };

            return result;
        }
    }
}