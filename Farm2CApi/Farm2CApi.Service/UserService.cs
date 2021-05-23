using AutoMapper;
using Farm2CApi.DataAccess.Interface;
using Farm2CApi.Dtos;
using Farm2CApi.Entities;
using Farm2CApi.Service.Interface;
namespace Farm2CApi.Service
{
    public class UserService : IUserService
    {
        private readonly IUserDataAccess _IUserDataAccess;

        private readonly IMapper _mapper;
        public UserService( IMapper mapper, IUserDataAccess userDataAccess)
        {
            _mapper = mapper;
            _IUserDataAccess = userDataAccess;
        }

        public UserInfoDto CheckUserExist(string phoneNumber)
        {
            var UserInfo = _IUserDataAccess.GetUserInfoByPhoneNumber(phoneNumber);
            if (UserInfo != null)
            {
                UserInfo.UserPassword = null;
            }
           
            return _mapper.Map<UserInfoDto>(UserInfo);
        }
        public UserInfoDto GetUserInfo(UserInfoDto userInfoDto)
        {
            var UserInfo = _IUserDataAccess.GetUserInfoByPassword(userInfoDto.PhoneNumber, userInfoDto.UserPassword);
            if (UserInfo != null)
            {
                UserInfo.UserPassword = null;
            }

            return _mapper.Map<UserInfoDto>(UserInfo);
        }
        public UserInfoDto RegisterUserInfo(UserInfoDto userInfoDto){
 
            var userInfo = _IUserDataAccess.RegisterUserInfo(_mapper.Map<UserInfo>(userInfoDto));
            if (userInfo != null)
            {
                userInfo.UserPassword = null;
            }

            return _mapper.Map<UserInfoDto>(userInfo);
        }

    }
}
