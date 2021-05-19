using Farm2CApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Farm2CApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private IHomeService _ihomeService;

        public HomeController(IHomeService ihomeService)
        {
            _ihomeService = ihomeService;
        }

        [HttpGet]
        [Route("GetData")]
        public IActionResult GetBasketItems()
        {
            var list = _ihomeService.GetBasketItems();
            return Ok(list);
        }
    }
}
