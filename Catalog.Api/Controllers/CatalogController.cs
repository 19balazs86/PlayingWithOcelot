using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class CatalogController : ControllerBase
  {
    private readonly Random _random = new Random();

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "Catalog #1", "Catalog #2", "Catalog #3" };
    }

    [HttpGet("aggregate")]
    public ActionResult<IEnumerable<string>> Aggregate()
    {
      if (_random.NextDouble() < 0.4)
        return StatusCode(500);

      return Get();
    }
  }
}
