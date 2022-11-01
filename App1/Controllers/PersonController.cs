namespace App1.Controllers;

using App1.Contracts;

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


[ApiController]
[Route("[controller]/[action]")]
public class PersonController : CQRSControllerBase
{
    private readonly StatusList status;

    public PersonController(ILogger<PersonController> logger, IMediator mediator, StatusList status)
        : base(logger, mediator)
    {
        this.status = status;
    }

    [HttpGet]
    public async Task<IActionResult> GetPeople()
    {
        GetPeopleRequest request = new();

        return await CallMediator(request);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPersonAsync(int id)
    {
        GetPersonRequest request = new(id);

        return await CallMediator(request);
    }

    [HttpPost]
    public async Task<IActionResult> AddPersonAsync([FromBody] CreatePersonRequest request)
    {
        status.CurrentStatus.Add("Adding person");
        return await CallMediator(request);
    }

    [HttpPut]
    public async Task<IActionResult> UpdatePersonAsync([FromBody] UpdatePersonRequest request)
    {
        return await CallMediator(request);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePersonAsync(int id)
    {
        DeletePersonRequest request = new(id);

        return await CallMediator(request);
    }
}
