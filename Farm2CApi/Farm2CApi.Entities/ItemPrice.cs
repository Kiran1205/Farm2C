using System;
using System.ComponentModel.DataAnnotations;

namespace Farm2CApi.Entities
{
    public class ItemPrice
    {
        [Key]
        public int ItemPriceID { get; set; }

        public int ItemID { get; set; }

        public int QuantityID { get; set; }

        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ItemPrice price &&
                   ItemPriceID == price.ItemPriceID &&
                   ItemID == price.ItemID &&
                   QuantityID == price.QuantityID &&
                   Price == price.Price &&
                   StartDate == price.StartDate &&
                   EndDate == price.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ItemPriceID, ItemID, QuantityID, Price, StartDate, EndDate);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
