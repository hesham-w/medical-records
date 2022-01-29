using System;
using System.Collections.Generic;

namespace Api.Customers.Data
{
    public partial class Customer
    {
        public Customer()
        {
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? AddressLine1 { get; set; }
        public string AddressLine2 { get; set; } = null!;
        public string? City { get; set; }
        public DateTimeOffset? Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset Modified { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
