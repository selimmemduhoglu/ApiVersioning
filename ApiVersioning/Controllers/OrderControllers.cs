using ApiVersioning.Serveices;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrderControllers : Controller
    {
        [HttpGet]
        public IActionResult GetOrder()
        {
            var list = OrderDataService.GetOrders();

            return Ok(list);
        }
    }
}
