using ProSummit.Core.Enums;

namespace ProSummit.Core.Entities.TicketsContext
{
    public class SummitOrder : BaseEntity
    {
        public SummitOrder(SummitCustomer customer)
        {
            Customer = customer;
            Purchase = DateTime.UtcNow;


            TypePass = EtypePass.InPerson;
            Tickets = new List<SummitOrderItems>();
        }

        public SummitCustomer Customer { get; private set; }
        public DateTime Purchase { get; private set; }
        public EtypePass TypePass { get; private set; }
        public float TotalPrice { get; private set; }

        public List<SummitOrderItems> Tickets { get; private set; }


        public void SetupOrder(List<SummitCatalog> tickets)
        {
            foreach (var ticket in tickets)
            {
                var ticketPrice = ticket.Price + ticket.ServiceFee;
                TotalPrice += ticketPrice;

                Tickets.Add(new SummitOrderItems(ticket.Title, ticketPrice));

            }

        }
    }
}
