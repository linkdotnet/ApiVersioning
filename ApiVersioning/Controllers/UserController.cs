using System;
using ApiVersioning.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V1;

[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public ResponseDto GetUser()
    {
        return new ResponseDto
        {
            UserId = Guid.NewGuid(),
            UserName = "Link",
        };
    }
}