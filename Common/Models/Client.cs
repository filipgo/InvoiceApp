using System;

namespace ExampleInvoiceApp.Common.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string TaxId { get; set; }
        public Address Address { get; set; }
    }
}