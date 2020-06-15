using CustomerTracker.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerTracker.Domain.Models;

namespace CustomerTracker.Application.Commands.CustomerNotes
{
    public class CreateCustomerNoteCommand : ICommand<CreateCustomerNoteDto, string>
    {
        private readonly IApplicationDbContext _context;

        public CreateCustomerNoteCommand(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> ExecuteAsync(CreateCustomerNoteDto model)
        {
            var CustomerNote = new CustomerNote()
            {
                Id = Guid.NewGuid().ToString(),
                Text = model.Text,
                Subject = model.Subject,
                DateAdded = DateTime.Now,
                CustomerId = model.CustomerId
            };

            try
            {
                await _context.CustomerNotes.AddAsync(CustomerNote);
                await _context.SaveChangesAsync();
                return CustomerNote.Id;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
