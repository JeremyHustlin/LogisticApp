namespace LogisticApp.ModelsCustomer
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Product_Info { get; set; }
        public Order Orders { get; set; }
        public string OrderId { get; set; }

    }
}
