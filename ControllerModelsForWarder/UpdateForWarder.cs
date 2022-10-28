using LogisticApp.ModelsForWarder;
namespace LogisticApp.ControllerModelsForWarder
{
    public class UpdateForWarder
    {
        public string Id { get; set; }
        public string Company_Name { get; set; }
        public string Call_Centre_Phone { get; set; }
        public List<AddDriver> Drivers { get; set; }

        public UpdateSchedule Schedules { get; set; }

        public List<UpdateVehicle> Vehicles { get; set; }
    }
}
