﻿
namespace LogisticApp.ModelsCustomer
{
    public class OrderLocation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Order> Orders { get; set; }
        

    }
}
