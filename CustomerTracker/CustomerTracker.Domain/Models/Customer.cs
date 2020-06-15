using CustomerTracker.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CustomerTracker.Domain.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public ActiveStatus ActiveStatus { get; set; }
        public DateTime DateAdded { get; set; }

        //navigation properties for entity framework
        public virtual IList<ContactInfo> ContactInfos { get; set; }
        public virtual IList<CustomerNote> CustomerNotes { get; set; }
    }
}
