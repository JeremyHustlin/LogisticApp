



using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticApp.ModelsCustomer
{
    public class Customer
    {
        public string Id { get; set; }
        public string Company_Name { get; set; }// numele la companie
        public string CallCentrePhone { get; set; }//numarul de telefon
        public List<Order> Orders { get; set; }
    }
}
