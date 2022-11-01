namespace App1.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class StatusController : ControllerBase
{
    private readonly StatusList status;

    public StatusController(StatusList status)
    {
        this.status = status;
    }

    [HttpGet]
    public IActionResult GetStatus()
    {
        return Ok(status.CurrentStatus);
    }
}
