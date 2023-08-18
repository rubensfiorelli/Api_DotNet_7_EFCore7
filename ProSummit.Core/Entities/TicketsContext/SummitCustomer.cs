using ProSummit.Core.ValueObject;

namespace ProSummit.Core.Entities.TicketsContext
{
    public class SummitCustomer
    {
        public SummitCustomer(Guid id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public virtual Address? Address { get; private set; }
    }


}
