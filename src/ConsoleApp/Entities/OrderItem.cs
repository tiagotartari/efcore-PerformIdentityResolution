namespace ConsoleApp.Entities
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
