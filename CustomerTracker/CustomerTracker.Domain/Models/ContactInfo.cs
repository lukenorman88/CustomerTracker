using CustomerTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTracker.Domain.Models
{
    public class ContactInfo
    {
        public string Id { get; set; }
        public string ContactDetail { get; set; }
        public string Description { get; set; }
        public ContactType ContactType { get; set; }
        public DateTime DateAdded { get; set; }
        public string CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
