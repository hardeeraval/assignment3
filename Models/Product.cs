namespace Assignment__3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Pricing { get; set; }
        public decimal ShippingCost { get; set; }
        
        // Navigation property for comments
        public ICollection<Comment> Comments { get; set; }
    }
}
