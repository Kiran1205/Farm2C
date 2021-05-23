
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
    public class UserController : ControllerBase
    {
        private IUserService _IUserService;

        public UserController(IUserService iService)
        {
            _IUserService = iService;
        }

        [HttpGet]
        [Route("checkuserexist")]
        public IActionResult CheckUserExist(string phonenumber)
        {
            var list = _IUserService.CheckUserExist(phonenumber);
            return Ok(list);
        }

        [HttpPost]
        [Route("getuserInfo")]
        public IActionResult getuserInfo([FromBody] UserInfoDto userInfoDto)
        {
            var list = _IUserService.GetUserInfo(userInfoDto);
            return Ok(list);
        }
        [HttpPost]
        [Route("registeruserInfo")]
        public IActionResult registeruserInfo([FromBody] UserInfoDto userInfoDto)
        {
            var list = _IUserService.RegisterUserInfo(userInfoDto);
            return Ok(list);
        }
    }
        
}
