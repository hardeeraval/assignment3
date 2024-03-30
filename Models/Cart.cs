namespace Assignment__3.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        
        // Foreign keys
        public int ProductId { get; set; }
        public int UserId { get; set; }
        
        // Navigation properties
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
