
using Farm2CApi.Dtos;
using Farm2CApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farm2CApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private IHomeService _ihomeService;

        public AdminController(IHomeService ihomeService)
        {
            _ihomeService = ihomeService;
        }

        [HttpPost]
        [Route("SaveItemms")]
        public IActionResult SaveItemms([FromBody]ItemDto  itemsDto)
        {
            var list = _ihomeService.SaveItem(itemsDto);
            return Ok(list);
        }
    }
}
