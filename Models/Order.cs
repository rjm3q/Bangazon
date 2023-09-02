namespace Bangazon.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StatusUpdateDate { get; set; }
    }
}