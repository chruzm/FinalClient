namespace Client.Models
{
    public class OrderObject
    {
        public int ordernumber { get; set; }
        public int price { get; set; }
        public string items { get; set; }
        public string adr { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}