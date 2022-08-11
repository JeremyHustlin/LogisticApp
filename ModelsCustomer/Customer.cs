



using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticApp.ModelsCustomer
{
    public class Customer
    {
        public string Id { get; set; }
        public string Company_Name { get; set; }// numele la companie
        public string Call_Centre_Phone { get; set; }//numarul de telefon


        public Order Orders { get; set; }

       
        public string OrderId { get; set; }
        public OrderLocation OrderLocation { get; set; }
        public string OrderLocationId { get; set; }
        public Product Product  { get; set; }
        public string ProductId { get; set; }
    }
}
