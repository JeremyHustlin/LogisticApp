using LogisticApp.ModelsForWarder;
using LogisticApp.ModelsCustomer;
using LogisticApp.ModelsDelivers;
namespace LogisticApp.ControllerModelsForWarder
{
    public class AddForWarder
    {
        public string Id { get; set; }
        public string Company_Name { get; set; }
        public string Call_Centre_Phone { get; set; }
        public List<AddDriver> Drivers { get; set; }

        public Schedule Schedules { get; set; }

        public List<AddVehicle> Vehicles { get; set; }
    }
}
