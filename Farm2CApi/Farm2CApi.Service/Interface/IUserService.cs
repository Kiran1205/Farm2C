using Farm2CApi.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm2CApi.Service.Interface
{
    public interface IUserService
    {
        UserInfoDto CheckUserExist(string phoneNumber);

        UserInfoDto GetUserInfo(UserInfoDto userInfoDto);

        UserInfoDto RegisterUserInfo(UserInfoDto userInfoDto);

        UserAddressDto SaveUserAddress(UserAddressDto userAddressDto);

        List<UserAddressDto> LoadUserAddress(int userId);
    }
}
