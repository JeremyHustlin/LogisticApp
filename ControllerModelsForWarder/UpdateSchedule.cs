using LogisticApp.ControllerModelsCustomer;
namespace LogisticApp.ControllerModelsForWarder
{
    public class UpdateSchedule
    {
        public string Id { get; set; }
        public UpdateDriver Driver { get; set; }
        public UpdateOrderLocation OrderLocation { get; set; }
    }
}
