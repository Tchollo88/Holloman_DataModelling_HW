namespace Holloman_DataModelling_HW.Models
{
    public class CustomerLikes
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int LikeId { get; set; }
        public Like Like { get; set; }
    }
}
