namespace LogisticApp.ControllerModelsCustomer
{
    public class UpdateOrder
    {
        public string Id { get; set; }
        public UpdateCustomer Customers { get; set; }
        public string Name { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public DateTime DateTime { get; set; }
        public UpdateOrderLocation OrderLocations { get; set; }

        public List<UpdateProduct> Products { get; set; }
    }
}
