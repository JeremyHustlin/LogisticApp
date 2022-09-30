

namespace LogisticApp.ControllerModelsCustomer
{
    public class AddOrder
    {

        public string Id { get; set; }
        public  AddCustomer Customers { get; set; }
        public string Name { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public DateTime DateTime { get; set; }
        public AddOrderLocation OrderLocations { get; set; }
       
        public List<AddProduct> Products { get; set; }
        
        



    }
}
