using System;

namespace Farm2CApi.Dtos
{
    public class UnitsDto
    {
      
        public int UnitID { get; set; }

        public string UnitName { get; set; }

        public bool Active { get; set; }

        public override bool Equals(object obj)
        {
            return obj is UnitsDto units &&
                   UnitID == units.UnitID &&
                   UnitName == units.UnitName &&
                   Active == units.Active;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UnitID, UnitName, Active);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
