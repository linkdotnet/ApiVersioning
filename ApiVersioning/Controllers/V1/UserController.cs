using System;
using ApiVersioning.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    public class UserController : ControllerBase
    {
        [Route("user")]
        [HttpGet]
        public ResponseDtoV1 GetUser()
        {
            return new ResponseDtoV1
            {
                UserId = Guid.NewGuid(),
                UserName = "Link",
            };
        }
    }
}