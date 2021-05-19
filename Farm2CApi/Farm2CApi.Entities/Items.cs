using System;
using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        public int ItemCategoryID { get; set; }

        public string ItemName { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public int UnitID { get; set; }

        public byte[] ItemImage { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Item items &&
                   ItemID == items.ItemID &&
                   ItemCategoryID == items.ItemCategoryID &&
                   ItemName == items.ItemName &&
                   Description == items.Description &&
                   Active == items.Active &&
                   UnitID == items.UnitID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ItemID, ItemCategoryID, ItemName, Description, Active, UnitID, ItemImage);
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
