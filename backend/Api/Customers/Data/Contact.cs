using System;
using System.Collections.Generic;

namespace Api.Customers.Data
{
    public partial class Contact
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public bool Disabled { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
