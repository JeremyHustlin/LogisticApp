

using ServiceStack.DataAnnotations;

namespace LogisticApp.ModelsCustomer
{
    public class Order
    {

        public string Id { get; set; }
        public  Customer Customers { get; set; }
        public string CustomerId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public DateTime DateTime { get; set; }
        public OrderLocation OrderLocations { get; set; }
        public string OrderLocationId { get; set; }
        public List<Product> Products { get; set; }
        
        



    }
}
