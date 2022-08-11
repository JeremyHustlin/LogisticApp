using LogisticApp.ModelsCustomer;
namespace LogisticApp.ModelsForWarder
{
    public class Schedule
    {
        public string Id { get; set; }
        public Driver Driver { get; set; }
        public string DriverId { get; set; }

        public OrderLocation OrderLocation { get; set; }
        public string OrderLocationId { get; set; }
    }
}
