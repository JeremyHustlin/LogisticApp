using LogisticApp.ModelsForWarder;
using LogisticApp.ModelsCustomer;
namespace LogisticApp.ModelsDelivers

{
    public class Delivers
{
        public string Id { get; set; }
        public string Name { get; set; }
    public ForWarder ForWarder { get; set; }
    public string ForWarderId { get; set; }
    public Customer Customer { get; set; }
    public string CustomerId { get; set; }
}
}
