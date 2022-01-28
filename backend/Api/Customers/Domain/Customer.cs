namespace Api.Customers.Domain
{
    public class Customer
    {
        public Guid Id { get; private set; }
        //public Address Address { get; private set; }
        //public CustomerPreferences Preferences { get; private set; }

        //public Customer(Address Address)
        //{
        //    Guard.NotNull(Address, nameof(Address));

        //    this.Address = Address;
        //    this.Preferences = new CustomerPreferences(CreateCaseEnabled: false);

        //    this.Id = Guid.NewGuid();
        //}

        //public Customer(CustomerPreferences Preferences)
        //{
        //    //Guard.NotNull(Address, nameof(Address));
        //    Guard.NotNull(Preferences, nameof(Preferences));

        //    //this.Address = Address;
        //    this.Preferences = Preferences;

        //    this.Id = Guid.NewGuid();
        //}

        public Customer(Guid Id)
        {
            this.Id = Id;
        }
    }

    public class CustomerPreferences
    {
        public Guid Id { get; private set; }
        public bool CreateCaseEnabled { get; private set; }

        public CustomerPreferences(bool CreateCaseEnabled)
        {
            this.CreateCaseEnabled = CreateCaseEnabled;
        }
    }

}