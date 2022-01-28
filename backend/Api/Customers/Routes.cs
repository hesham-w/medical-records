using Api.Customers.Features;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Customers
{
    [ApiController]
    [Route("customer")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateCustomer([FromBody] CreateCustomer.Command command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }

    [ApiController]
    [Route("customer/{id}/contact")]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateContact([FromBody] CreateContact.Command command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
