using CustomerTracker.Application.Commands;
using CustomerTracker.Application.Commands.CustomerNotes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerTracker.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerNotesController : ControllerBase
    {
        private readonly ICommand<CreateCustomerNoteDto, string> _command;

        public CustomerNotesController(ICommand<CreateCustomerNoteDto, string> command)
        {
            _command = command;
        }

        [HttpPost]
        public async Task<IActionResult> CreatecustomerNote(CreateCustomerNoteDto model)
        {
            var result = await _command.ExecuteAsync(model);
            return Ok(result);
        }
    }
}
