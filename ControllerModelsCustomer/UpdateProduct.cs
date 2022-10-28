namespace LogisticApp.ControllerModelsCustomer
{
    public class UpdateProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Product_Info { get; set; }
        public List<UpdateOrder> Orders { get; set; }

    }
}
