namespace BarRating.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; } // Връзка с User
        public User User { get; set; }
        public int BarId { get; set; } // Връзка с Bar
        public Bar Bar { get; set; }
    }

}
