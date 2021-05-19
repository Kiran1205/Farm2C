using System;
using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class UserAddress
    {
        [Key]
        public int UserAddressID { get; set; }
        public int UserInfoID { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string AlternatePhoneNumber { get; set; }

        public int PinCode { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string LandMark { get; set; }

        public bool DefaultAddress { get; set; }

        public bool IsActive { get; set; }

        public override bool Equals(object obj)
        {
            return obj is UserAddress address &&
                   UserAddressID == address.UserAddressID &&
                   UserInfoID == address.UserInfoID &&
                   Name == address.Name &&
                   PhoneNumber == address.PhoneNumber &&
                   AlternatePhoneNumber == address.AlternatePhoneNumber &&
                   PinCode == address.PinCode &&
                   Address == address.Address &&
                   State == address.State &&
                   LandMark == address.LandMark &&
                   DefaultAddress == address.DefaultAddress &&
                   IsActive == address.IsActive;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(UserAddressID);
            hash.Add(UserInfoID);
            hash.Add(Name);
            hash.Add(PhoneNumber);
            hash.Add(AlternatePhoneNumber);
            hash.Add(PinCode);
            hash.Add(Address);
            hash.Add(State);
            hash.Add(LandMark);
            hash.Add(DefaultAddress);
            hash.Add(IsActive);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
