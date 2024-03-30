namespace Assignment__3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        
        // Foreign keys
        public int UserId { get; set; }
        
        // Navigation property
        public User User { get; set; }
    }
}
