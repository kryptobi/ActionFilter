using Microsoft.AspNetCore.Mvc;

namespace ActionFilter.Controllers;

public class TestController : Controller
{
    [HttpGet("test")]
    public async Task<IActionResult> Foo(
        [FromQuery] string foo,
        CancellationToken cancellationToken)
    {
        return Json(foo);
    }
}