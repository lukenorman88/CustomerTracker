using CustomerTracker.Application.Commands;
using CustomerTracker.Application.Commands.Customers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerTracker.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICommand<CreateCustomerDto, string> _command;

        public CustomerController(ICommand<CreateCustomerDto, string> command)
        {
            _command = command;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto model)
        {
            var result = await _command.ExecuteAsync(model);
            return Ok(result);
        }
    }
}
