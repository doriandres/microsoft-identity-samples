using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace WebApiProject.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/data")]
public class DataController(ILogger<DataController> logger) : ControllerBase
{
    [HttpGet("all")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public string[] GetAll()
    {
        logger.LogInformation("data controller all endpoint called");

        return ["foo", "bar", "baz"];
    }
}
