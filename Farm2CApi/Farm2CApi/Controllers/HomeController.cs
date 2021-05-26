using Farm2CApi.Dtos;
using Farm2CApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet]
        [Route("GetSelectedItems")]
        public IActionResult GetSelectedItems(int userInfoId)
        {
            var list = _ihomeService.GetBasketSelectedItems(userInfoId);
            return Ok(list);
        }

        [HttpGet]
        [Route("getbasketItems")]
        public IActionResult GetBasketItems(int userInfoId)
        {
            var list = _ihomeService.GetBasketItems(userInfoId);
            return Ok(list);
        }

        [HttpPost]
        [Route("saveItemInBasket")]
        public IActionResult SaveItemInBasket([FromBody]UserBasketDto userbasket)
        {
            var list = _ihomeService.SaveItemInBasket(userbasket);
            return Ok(list);
        }
        [HttpDelete]
        [Route("removeItemInBasket")]
        public IActionResult removeItemInBasket(int userbasketId)
        {
            var list = _ihomeService.RemoveItemInBasket(userbasketId);
            return Ok(list);
        }

        [HttpGet]
        [Route("placeorder")]
        public IActionResult PlaceOrder(int userInfoID, int useraddressId)
        {
            var list = _ihomeService.PlaceOrder(userInfoID, useraddressId);
            return Ok(list);
        }     
    }
}
