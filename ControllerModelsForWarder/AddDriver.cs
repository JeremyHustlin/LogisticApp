using Microsoft.AspNetCore.Identity;
using LogisticApp.ModelsForWarder;
using LogisticApp.ModelsCustomer;
using LogisticApp.ModelsDelivers;
namespace LogisticApp.ControllerModelsForWarder
{
    public class AddDriver:IdentityUser
    {
        public string Id { get; set; }
        public List<AddVehicle> Vehicles { get; set; }
        public List<AddVehicleLocation> VehicleLocations { get; set; }

        public bool Free_or_Busy { get; set; }//true daca ii free sau false daca ii busy 
        public DayOfWeek DayOfWeek { get; set; }// ziua comenzii

        public TimeSpan Hour { get; set; }// ora comenzii
    }
}
