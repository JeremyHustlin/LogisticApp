using Microsoft.AspNetCore.Identity;

namespace LogisticApp.ModelsForWarder
{
    public class Driver:IdentityUser
    {
        public string Id { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<VehicleLocation> VehicleLocations { get; set; }
      
        public bool Free_or_Busy { get; set; }//true daca ii free sau false daca ii busy 
        public DayOfWeek DayOfWeek { get; set; }// ziua comenzii

        public TimeSpan Hour { get; set; }// ora comenzii
    }
}
