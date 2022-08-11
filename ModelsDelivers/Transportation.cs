namespace LogisticApp.ModelsDelivers
{
    public class Transportation
    {
        public string Id { get; set; }
        public int Distance { get; set; }
        public Price Prices { get; set; }
        public string PriceId { get; set; }
    }
}
