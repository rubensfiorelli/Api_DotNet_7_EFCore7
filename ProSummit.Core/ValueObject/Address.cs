namespace ProSummit.Core.ValueObject
{
    public record Address
    {
        public Address(int number, string complement, string street, string city, string state, string zipCode)
        {
            Number = number;
            Complement = complement;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public int Number { get; private init; }
        public string Complement { get; private init; }
        public string Street { get; private init; }
        public string City { get; private init; }
        public string State { get; private init; }
        public string ZipCode { get; private init; }
    }
}
