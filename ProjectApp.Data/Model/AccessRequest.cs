using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class AccessRequest
    {
        public AccessRequest()
        {
            EmailQueue = new HashSet<EmailQueue>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }
        public string SubmissionId { get; set; }
        public int RArsId { get; set; }
        public DateTime ArsDate { get; set; }

        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual AccessRequestStatus RArs { get; set; }
    }
}
