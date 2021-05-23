using Dapper;
using Farm2CApi.DataAccess.Interface;
using Farm2CApi.Entities;
using Farm2CApi.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm2CApi.DataAccess
{
    public class UserDataAccess : IUserDataAccess
    {
        public IDapper _idapper;
        private readonly Farm2CEntities _farm2CEntities;
        public UserDataAccess(IDapper idrapper, Farm2CEntities _context)
        {
            _farm2CEntities = _context;
            _idapper = idrapper;
        }
        public UserInfo GetUserInfoByPhoneNumber(string PhoneNumber)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.Get<UserInfo>($"select * from UserInfo where PhoneNumber = '{PhoneNumber}'", dbparams, System.Data.CommandType.Text);
            return results;
        }
        public UserInfo GetUserInfoByPassword(string PhoneNumber,string password)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.Get<UserInfo>($"select * from UserInfo where PhoneNumber = '{PhoneNumber}' and UserPassword='{password}'", dbparams, System.Data.CommandType.Text);
            return results;
        }
        public UserInfo RegisterUserInfo(UserInfo userInfo)
        {
            _farm2CEntities.UserInfo.Add(userInfo);
            _farm2CEntities.SaveChanges();
            return userInfo;
        }
    }
}
