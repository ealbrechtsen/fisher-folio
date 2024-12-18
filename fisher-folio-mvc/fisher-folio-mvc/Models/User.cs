namespace fisher_folio_mvc.Models
{
    public class User
    {
        // Primary key
        public int UserId { get; set; }

        // Attributes
        public string Name { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
    }
}
