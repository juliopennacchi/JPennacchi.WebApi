using JPennacchi.Application.RequestResponse;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace JPennacchi.WebApi.Extensions
{
    public static class ControllerExtension
    {
        public static ActionResult GetResponse(this ControllerBase controller, Response response)
        {
            if(response.Valid)
                return controller.Ok(response);
            else
            {
                switch (response.Error.Type)
                {
                    case ErrorType.ValidationError: 
                        return controller.BadRequest(response.Error.Messages);
                    case ErrorType.InternalError:
                        return controller.StatusCode(StatusCodes.Status500InternalServerError, response.Error);
                    default: return controller.Ok();
                }
            }
        }
    }
}
