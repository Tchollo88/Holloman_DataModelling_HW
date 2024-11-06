namespace Holloman_DataModelling_HW.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Email { get; set; }

        /*Joins*/
        /*Phone Number M -> O*/
        public ICollection<PhoneNumber>? PhoneNumbers { get; set; }
        /*Address M -> M*/
        public ICollection<Address>? Addresses { get; set; }
        /*Likes M -> M*/
        public ICollection<CustomerLikes>? CustomerLikes { get; set; }
    }
}
