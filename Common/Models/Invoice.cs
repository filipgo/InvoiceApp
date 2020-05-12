using System;
using System.Collections.Generic;
using ExampleInvoiceApp.Common.Models.Enums;

namespace ExampleInvoiceApp.Common.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Number { get; set; }
        
        public Client Client { get; set; }
        public DateTime SellDate { get; set; }
        public DateTime IssueDate { get; set; }
        public int PaytimeDays { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public bool IsPaid { get; set; }
        
        public IList<InvoiceRow> InvoiceRows { get; set; } = new List<InvoiceRow>();
        
        public double NetSum { get; set; }
        public double GrossSum { get; set; }
        
    }
}