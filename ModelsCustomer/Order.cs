

using ServiceStack.DataAnnotations;

namespace LogisticApp.ModelsCustomer
{
    public class Order
    {

        public string Id { get; set; }
        public List<Customer> Customers { get; set; }
        public DayOfWeek DayOfWeek { get; set; }// ziua comenzii

        public TimeSpan Hour { get; set; }// ora comenzii
        public List<OrderLocation> OrderLocations { get; set; }
        public List<Product>Products { get; set; }
        



    }
}
