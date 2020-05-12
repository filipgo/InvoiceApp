using System;
using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Common.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ExampleInvoiceApp.App.Controllers
{
    public class InvoiceController : Controller
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateInvoiceRequest request)
        {
            throw new NotImplementedException();
        }
        
        [HttpPatch("update/{invoiceId}")]
        public async Task<IActionResult> Update(UpdateInvoiceRequest request)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet("{invoiceId}")]
        public async Task<ActionResult<Invoice>> Read(int invoiceId)
        {
            throw new NotImplementedException();
        }
        
        [HttpDelete("delete/{agreementId}")]
        public async Task<IActionResult> Delete()
        {
            throw new NotImplementedException();
        }
    }
}