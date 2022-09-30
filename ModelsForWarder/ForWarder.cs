using Microsoft.AspNetCore.Identity;

namespace LogisticApp.ModelsForWarder
{
    public class ForWarder 
    {
        public string Id { get; set; }
        public string Company_Name { get; set; }
        public string Call_Centre_Phone {get;set;}
        public List<Driver> Drivers { get; set; }
       
        public Schedule Schedules { get; set; }
        public string SchedulesId { get; set; }
     
        public List<Vehicle> Vehicles { get; set; }
       
     


    }
}
