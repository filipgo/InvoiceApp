namespace ExampleInvoiceApp.Common.Models
{
    public class InvoiceRow
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int VatRate { get; set; }
        public int Quantity { get; set; }
        
    }
}