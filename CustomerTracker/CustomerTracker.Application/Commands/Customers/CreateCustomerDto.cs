using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerTracker.Application.Commands.Customers
{
    public class CreateCustomerDto
    {
        [StringLength(maximumLength: 10)]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        [Required]
        [StringLength(maximumLength: 128)]
        public string ContactDetail { get; set; }

        [StringLength(maximumLength: 300)]
        public string ContactDescription { get; set; }

        [Required]
        public int ContactType { get; set; }
    }
}
