
namespace LogisticApp.ModelsCustomer
{
    public class OrderLocation
    {
        public string Id { get; set; }
        public string Adress { get; set; }
        public Order Orders { get; set; }
        public string OrderId { get; set; }

    }
}
