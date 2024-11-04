namespace Holloman_DataModelling_HW.Models
{
    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public string Number {  get; set; }
        public string Type { get; set; }

        /*Join*/
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
