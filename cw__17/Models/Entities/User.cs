namespace cw__17.Models.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = false;
        public decimal Balance { get; set; } = 1000000;
        public List<Product> Products { get; set; }
    }
}
