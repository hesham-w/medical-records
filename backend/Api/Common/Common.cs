namespace Api.Common
{
    public class Address
    {
        public State State { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string City { get; private set; }
        public ZipCode ZipCode { get; private set; }

        public Address(State State, string AddressLine1, string AddressLine2, string City, ZipCode ZipCode)
        {
            Guard.NotNull(State, nameof(State));
            Guard.NotNullOrWhiteSpace(AddressLine1, nameof(AddressLine1));
            Guard.NotNullOrWhiteSpace(AddressLine2, nameof(AddressLine2));
            Guard.NotNullOrWhiteSpace(City, nameof(City));

            this.State = State;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.City = City;
            this.ZipCode = ZipCode;
        }
    }

    public class ZipCode
    {
        public string Value { get; private set; }

        public ZipCode(string Value)
        {
            Guard.NotNullOrWhiteSpace(Value, nameof(Value));

            this.Value = Value;
        }
    }

    public class State
    {
        public string StateAbbreviation { get; private set; }

        public State(string StateAbbreviation)
        {
            Guard.EnsureMinimumLength(StateAbbreviation, 2, nameof(StateAbbreviation));

            this.StateAbbreviation = StateAbbreviation;
        }
    }

}