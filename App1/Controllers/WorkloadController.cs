namespace App1.Controllers;
using App1.Contracts;

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("[controller]/[action]")]
public class WorkloadController : CQRSControllerBase
{
    public WorkloadController(ILogger<WorkloadController> logger, IMediator mediator)
        : base(logger, mediator) { }

    [HttpGet]
    public async Task<IActionResult> GetWorkloads()
    {
        GetWorkloadsRequest request = new();

        return await CallMediator(request);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetWorkloadAsync(int id)
    {
        GetWorkloadRequest request = new(id);

        return await CallMediator(request);
    }

    [HttpPost]
    public async Task<IActionResult> AddWorkloadAsync([FromBody] CreateWorkloadRequest request)
    {
        return await CallMediator(request);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateWorkloadAsync([FromBody] UpdateWorkloadRequest request)
    {
        return await CallMediator(request);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteWorkloadAsync(int id)
    {
        DeleteWorkloadRequest request = new(id);

        return await CallMediator(request);
    }
}
