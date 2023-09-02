namespace Bangazon.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Created_at { get; set; }
        public bool isSeller { get; set; }
    }
}