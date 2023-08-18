namespace ProSummit.Core.Entities.TicketsContext
{
    public sealed class SummitOrderItems : BaseEntity
    {
        public SummitOrderItems(string title, float price) : base()
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public float Price { get; set; }
    }
}
