using System;
using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class Units
    {
        [Key]
        public int UnitID { get; set; }

        public string UnitName { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Units units &&
                   UnitID == units.UnitID &&
                   UnitName == units.UnitName &&
                   Description == units.Description &&
                   Active == units.Active;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UnitID, UnitName, Description, Active);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
