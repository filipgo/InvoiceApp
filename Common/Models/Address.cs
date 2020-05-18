namespace ExampleInvoiceApp.Common.Models
{
    public class Address
    {
        public string Street { get; set; }
        
        public string BuildingNumber { get; set; }
        
        public string FlatNumber { get; set; }
        
        public int PostCode { get; set; }
        
        public string City { get; set; }
        
        public string Country { get; set; }
    }
}