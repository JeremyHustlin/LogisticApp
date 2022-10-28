using Microsoft.AspNetCore.Identity;
namespace LogisticApp.ControllerModelsForWarder
{
    public class UpdateDriver:IdentityUser
    {
        public string Id { get; set; }
        public List<UpdateVehicle> Vehicles { get; set; }
        public List<UpdateVehicleLocation> VehicleLocations { get; set; }

        public bool Free_or_Busy { get; set; } 
        public DayOfWeek DayOfWeek { get; set; }

        public TimeSpan Hour { get; set; }
    }
}
