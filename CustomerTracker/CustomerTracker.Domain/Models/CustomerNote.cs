using System;

namespace CustomerTracker.Domain.Models
{
    public class CustomerNote
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        public DateTime DateAdded { get; set; }
        public string CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
