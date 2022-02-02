using ApiVersioning.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V1;

[ApiController]
[Route("user")]
[ApiVersion("1.0", Deprecated = true)]
[ApiVersion("2.0")]
public class UserController : ControllerBase
{
    [HttpGet]
    [MapToApiVersion("1.0")]
    public ResponseDto GetUser()
    {
        return new ResponseDto
        {
            UserId = Guid.NewGuid(),
            UserName = "Link",
        };
    }

    [HttpGet]
    [MapToApiVersion("2.0")]
    public ResponseDtoV2 GetUserV2()
    {
        return new ResponseDtoV2
        {
            FirstName = "Steven",
            LastName = "Giesel",
            UserId = Guid.NewGuid(),
        };
    }
}