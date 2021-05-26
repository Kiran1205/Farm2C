using Farm2CApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm2CApi.DataAccess.Interface
{
    public interface IUserDataAccess
    {
        UserInfo GetUserInfoByPhoneNumber(string PhoneNumber);

        UserInfo GetUserInfoByPassword(string PhoneNumber, string password);

        UserInfo RegisterUserInfo(UserInfo userInfo);

        UserAddress SaveUserAddress(UserAddress userInfo);

        List<UserAddress> LoadUserAddress(int UserInfoID);
    }
}
