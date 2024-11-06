namespace Holloman_DataModelling_HW.Models
{
    public class Address
    {
        public int AddressId {  get; set; }
        public string StreetAdress { get; set; }
        public string? StreetAdress2 { get; set; }
        public string  City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        // helper - Navigational Properties
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
