using LogisticApp.ModelsForWarder;
using LogisticApp.ModelsCustomer;
namespace LogisticApp.ModelsDelivers

{
    public class Delivers
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Transportation Transportations { get; set; }
        public string TransportationId { get; set; }
   
}
}
