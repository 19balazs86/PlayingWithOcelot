using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class OrdersController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "Order #1", "Order #2", "Order #3" };
    }

    [HttpGet("aggregate")]
    public ActionResult<IEnumerable<string>> Aggregate()
    {
      return Get();
    }
  }
}
