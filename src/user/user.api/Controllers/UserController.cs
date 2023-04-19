using MediatR;
using Microsoft.AspNetCore.Mvc;
using user.application.Features.Addresses.Requests;
using user.application.Features.Users.Requests;
using user.domain;

namespace user.api.Controllers
{    
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/api/user/create")]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            var response = await _mediator.Send(new CreateUserCommand() { User = user }, CancellationToken.None);
            return Ok(response);
        }

        [HttpGet]
        [Route("/api/users")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _mediator.Send(new GetUserListCommand(), CancellationToken.None);
            return Ok(result);
        }

        [HttpPost]
        [Route("/api/address/create")]
        public async Task<IActionResult> CreateUserAddress([FromBody] Address address)
        {
            var response = await _mediator.Send(new CreateUserAddressCommand() {  Address = address }, CancellationToken.None);
            return Ok(response);
        }
    }
}
