namespace LogisticApp.ControllerModelsCustomer
{
    public class AddCustomer
    {
        public string Id { get; set; }
        public string Company_Name { get; set; }
        public string CallCentrePhone { get; set; }
        public List<AddOrder> Orders { get; set; }
    }
}
