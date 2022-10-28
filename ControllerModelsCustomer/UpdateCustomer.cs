namespace LogisticApp.ControllerModelsCustomer
{
    public class UpdateCustomer
    {

        public string Id { get; set; }
        public string Company_Name { get; set; }
        public string CallCentrePhone { get; set; }
        public List<UpdateOrder> Orders { get; set; }

    }
}
 