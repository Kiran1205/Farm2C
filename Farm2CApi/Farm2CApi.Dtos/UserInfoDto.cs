using System;

namespace Farm2CApi.Dtos
{
    public class UserInfoDto
    {
        public int UserInfoID { get; set; }

        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string UserPassword { get; set; }

        public override bool Equals(object obj)
        {
            return obj is UserInfoDto info &&
                   UserInfoID == info.UserInfoID &&
                   UserName == info.UserName &&
                   PhoneNumber == info.PhoneNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserInfoID, UserName, PhoneNumber);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
