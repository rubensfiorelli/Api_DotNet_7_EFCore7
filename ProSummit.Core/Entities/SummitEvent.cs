namespace ProSummit.Core.Entities
{
    public sealed class SummitEvent : BaseEntity
    {
        public SummitEvent(string title,
                           string description,
                           string place,
                           DateTime endDate,
                           int quantity,
                           string imgUrl,
                           string webSite) : base()
        {
            Title = title;
            Description = description;
            Place = place;
            StartDate = DateTime.UtcNow;
            EndDate = endDate;
            Quantity = quantity;
            ImgUrl = imgUrl;
            WebSite = webSite;
            IsDeleted = false;
            Speakers = new List<SummitSpeaker>();
            Batches = new List<SummitBatch>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Place { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Quantity { get; private set; }
        public string ImgUrl { get; private set; }
        public string WebSite { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<SummitSpeaker> Speakers { get; set; }
        public List<SummitBatch> Batches { get; set; }


        public void Update(string newTitle,
                           string newDescription,
                           string newPlace,
                           DateTime newStartDate,
                           DateTime newEndDate,
                           int newQuantity,
                           string newImgUrl,
                           string newWebSite)
        {

            Title = newTitle;
            Description = newDescription;
            Place = newPlace;
            StartDate = newStartDate;
            EndDate = newEndDate;
            Quantity = newQuantity;
            ImgUrl = newImgUrl;
            WebSite = newWebSite;

        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}
