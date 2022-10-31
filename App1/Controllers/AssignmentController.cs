namespace App1.Controllers;
using App1.Contracts;

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("[controller]/[action]")]
public class AssignmentController : CQRSControllerBase
{
    public AssignmentController(ILogger<AssignmentController> logger, IMediator mediator)
        : base(logger, mediator) { }

    [HttpGet]
    public async Task<IActionResult> GetAssignments()
    {
        GetAssignmentsRequest request = new();

        return await CallMediator(request);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAssignmentAsync(int id)
    {
        GetAssignmentRequest request = new(id);

        return await CallMediator(request);
    }

    [HttpPost]
    public async Task<IActionResult> AddAssignmentAsync([FromBody] CreateAssignmentRequest request)
    {
        return await CallMediator(request);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAssignmentAsync([FromBody] UpdateAssignmentRequest request)
    {
        return await CallMediator(request);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAssignmentAsync([FromBody] DeleteAssignmentRequest request)
    {
        return await CallMediator(request);
    }
}
