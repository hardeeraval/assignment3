namespace Assignment__3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        
        // Navigation property for orders
        public ICollection<Order> Orders { get; set; }
    }
}
