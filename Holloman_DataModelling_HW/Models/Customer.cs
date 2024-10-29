namespace Holloman_DataModelling_HW.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        /*Phone Number M -> O*/
        /*Address O -> M*/
        public string Email { get; set; }
        /*Likes M -> O*/
    }
}
