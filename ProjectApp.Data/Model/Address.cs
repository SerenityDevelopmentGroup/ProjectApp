using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Address
    {
        public Address()
        {
            Person = new HashSet<Person>();
            Supplier = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public DateTime Created { get; set; }
        public int? OldContactId { get; set; }
        public int? Sid { get; set; }

        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
