using System;
using ApiVersioning.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    public class UserController : ControllerBase
    {
        [Route("user")]
        [HttpGet]
        public ResponseDtoV2 GetUser()
        {
            return new ResponseDtoV2
            {
                UserId = Guid.NewGuid(),
                FirstName = "Warrior",
                LastName = "Link"
            };
        }
    }
}