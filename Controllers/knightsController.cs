using System;
using System.Collections.Generic;
using knights.Models;
using knights.Services;
using Microsoft.AspNetCore.Mvc;


namespace knights.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class knightsController : ControllerBase
  {
    private readonly KnightsService _service;
    public knightsController(KnightsService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Knight>> GetAll()
    {
      try
      {
        IEnumerable<Knight> knights = _service.GetAll();
        return Ok(knights);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

      //GET BY ID


      //PUT

      //DELETE
    }
  }
}
