using ProSummit.Core.Enums;

namespace ProSummit.Core.Entities.TicketsContext
{
    public sealed class SummitCatalog : BaseEntity
    {
        public SummitCatalog(string title,
                          string description,
                          EtypePass typePass,
                          float price,
                          float convenienceFee) : base()
        {
            Title = title;
            Description = description;
            TypePass = typePass;
            Price = price;
            ServiceFee = convenienceFee;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public EtypePass TypePass { get; private set; }
        public float Price { get; private set; }
        public float ServiceFee { get; private set; }


        public void Update(string newTitle, string newDescription, EtypePass newTypePass, float newPrice, float newConvenienceFee)
        {
            Title = newTitle;
            Description = newDescription;
            TypePass = newTypePass;
            Price = newPrice;
            ServiceFee = newConvenienceFee;

        }



    }
}
