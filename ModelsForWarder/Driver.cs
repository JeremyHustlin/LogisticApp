using Microsoft.AspNetCore.Identity;

namespace LogisticApp.ModelsForWarder
{
    public class Driver:IdentityUser
    {
        public string Id { get; set; }
        public Vehicle Vehicles { get; set; }
        public string VehicleId { get; set; }
        public bool Free_or_Busy { get; set; }//true daca ii free sau false daca ii busy 
        public DayOfWeek DayOfWeek { get; set; }// ziua comenzii

        public TimeSpan Hour { get; set; }// ora comenzii
    }
}
