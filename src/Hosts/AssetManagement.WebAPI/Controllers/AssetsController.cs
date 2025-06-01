using System.Net;
using AssetManagement.WebAPI.Common;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.WebAPI.Controllers;

[ApiController]
[Route("api/{version:apiVersion}/assets")]
public class AssetsController : ControllerBase
{
    public AssetsController()
    {
        
    }

    [HttpGet]
    public async Task<IActionResult> GetAssets()
    {
        return Ok(new ApiResponse
        {
            Result = "What the fuck???",
            StatusCode = HttpStatusCode.OK
        });
    }
}