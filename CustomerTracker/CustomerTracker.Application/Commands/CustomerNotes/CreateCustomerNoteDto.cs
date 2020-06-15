using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerTracker.Application.Commands.CustomerNotes
{
    public class CreateCustomerNoteDto
    {
        [Required]
        [StringLength(maximumLength: 250)]
        public string Text { get; set; }

        [Required]
        [StringLength(maximumLength: 20)]
        public string Subject { get; set; }

        [Required]
        public string CustomerId { get; set; }
    }
}
