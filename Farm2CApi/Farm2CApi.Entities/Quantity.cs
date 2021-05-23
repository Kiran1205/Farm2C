using System;
using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class Quantity
    {
        [Key]
        public int QuantityID { get; set; }

        public string QuantityType { get; set; }
        public int UnitID { get; set; }

        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Quantity quantity &&
                   QuantityID == quantity.QuantityID &&
                   QuantityType == quantity.QuantityType &&
                   UnitID == quantity.UnitID &&
                   Description == quantity.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(QuantityID, QuantityType, UnitID, Description);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
