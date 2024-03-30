namespace Assignment__3.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public string Image { get; set; }
        
        // Foreign keys
        public int ProductId { get; set; }
        public int UserId { get; set; }
        
        // Navigation properties
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
