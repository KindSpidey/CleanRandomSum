using CleanRandomSum.Application;
using CleanRandomSum.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanRandomSum.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        private readonly INumberService _service;
        public NumbersController(INumberService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Number>> Get()
        {
            var numbersFromService = _service.GetSum();
            return Ok(numbersFromService);
        }

    }
}