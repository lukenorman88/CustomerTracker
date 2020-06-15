using CustomerTracker.Application.Common;
using System.Threading.Tasks;
using CustomerTracker.Domain.Models;
using System;
using CustomerTracker.Domain.Enums;

namespace CustomerTracker.Application.Commands.Customers
{
    public class CreateCustomerCommand : ICommand<CreateCustomerDto, string>
    {
        private readonly IApplicationDbContext _context;

        public CreateCustomerCommand(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> ExecuteAsync(CreateCustomerDto model)
        {
            var Customer = new Customer()
            {
                Id = Guid.NewGuid().ToString(),
                Title = model.Title,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Dob = model.Dob,
                ActiveStatus = ActiveStatus.ACTIVE,
                DateAdded = DateTime.Now
            };

            var ContactInfo = new ContactInfo()
            {
                Id = Guid.NewGuid().ToString(),
                ContactDetail = model.ContactDetail,
                Description = model.ContactDescription,
                ContactType = (ContactType)model.ContactType,
                DateAdded = DateTime.Now,
                CustomerId = Customer.Id
            };

            try
            {
                await _context.Customers.AddAsync(Customer);
                await _context.ContactInfos.AddAsync(ContactInfo);
                await _context.SaveChangesAsync();
                return Customer.Id;
            }
            catch
            {
                throw new Exception();
            }            
        }
    }
}
