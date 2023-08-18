namespace ProSummit.Core.Entities
{
    public sealed class SummitBatch : BaseEntity
    {
        public SummitBatch(string title,
                     float priceInPerson,
                     float priceOnLine,
                     int quantity,
                     Guid summitEventId)
        {
            Title = title;
            PriceInPerson = priceInPerson;
            PriceOnLine = priceOnLine;
            StartDate = SummitEvent.StartDate;
            EndDate = SummitEvent.EndDate;
            Quantity = quantity;
            IsDeleted = false;
            SummitEventId = summitEventId;
        }

        public string Title { get; private set; }
        public float PriceInPerson { get; private set; }
        public float PriceOnLine { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Quantity { get; private set; }
        public bool IsDeleted { get; private set; }
        public Guid SummitEventId { get; private set; }
        public SummitEvent? SummitEvent { get; set; }

        public void Update(string newTitle, float newPriceInPerson, float newPriceOnLine, int newQuantity)
        {
            Title = newTitle;
            PriceInPerson = newPriceInPerson;
            PriceOnLine = newPriceOnLine;
            Quantity = newQuantity;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}