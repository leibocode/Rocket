using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.AspNetCore.Models
{
    public enum StatusCode
    {
        Fail = -1,
        Success= 200,
        BadRequest = 400,
        UnAuthorized = 401,
        InternalException = 500
    }
}
