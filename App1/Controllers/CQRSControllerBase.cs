namespace App1.Controllers;

using App1.Contracts;

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class CQRSControllerBase : ControllerBase
{
    protected readonly ILogger logger;
    protected readonly IMediator mediator;

    public CQRSControllerBase(ILogger logger, IMediator mediator)
    {
        this.logger = logger;
        this.mediator = mediator;
    }

    protected async Task<IActionResult> CallMediator(object request)
    {
        return (await mediator.Send(request)) is not MediatorResponse response
            ? BadRequest("No response")
            : (response.Status switch
            {
                200 => Ok(response.Result),
                400 => BadRequest(response.Result),
                500 => Conflict(response.Result),
                _ => NoContent(),
            });
    }
}
