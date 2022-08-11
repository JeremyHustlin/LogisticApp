using Microsoft.AspNetCore.Identity;

namespace LogisticApp.ModelsForWarder
{
    public class ForWarder : IdentityUser
    {
        public string Id { get; set; }
        public string Company_Name { get; set; }// numele la companie
        public string Call_Centre_Phone {get;set;}//numarul de telefon
        public Driver Drivers { get; set; }
        public string DriverId { get; set; }
        public Schedule Schedules { get; set; }
        public string ScheduleId { get; set; }
        public Vehicle Vehicles { get; set; }
        public string VehicleId { get; set; }
        public VehicleLocation VehicleLocations { get; set; }
        public string VehicleLocationId { get; set; }


    }
}
