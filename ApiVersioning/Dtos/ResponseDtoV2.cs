using System;

namespace ApiVersioning.Dtos
{
    public class ResponseDtoV2
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}