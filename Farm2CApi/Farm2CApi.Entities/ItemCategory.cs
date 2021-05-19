using System;
using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class ItemCategory
    {
        [Key]
        public int ItemCategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ItemCategory category &&
                   ItemCategoryID == category.ItemCategoryID &&
                   CategoryName == category.CategoryName &&
                   Description == category.Description &&
                   Active == category.Active;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ItemCategoryID, CategoryName, Description, Active);
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
