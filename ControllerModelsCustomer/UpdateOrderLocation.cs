namespace LogisticApp.ControllerModelsCustomer
{
    public class UpdateOrderLocation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<UpdateOrder> Orders { get; set; }
    }
}
