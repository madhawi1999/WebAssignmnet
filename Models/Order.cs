namespace A_1_3647.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public string OStatus { get; set; }
        public int Total { get; set; }
        public DateTime Odate { get; set; }
        public DateTime Expected_delivery_date { get; set; }
    }
}
