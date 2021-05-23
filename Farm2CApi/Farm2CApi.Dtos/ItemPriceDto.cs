using System;

namespace Farm2CApi.Dtos
{
    public class ItemPriceDto
    {
      
        public int ItemPriceID { get; set; }

        public int ItemID { get; set; }

        public int QuantityID { get; set; }

        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string PriceCode { get; set; }

        public bool DefaultSelection { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ItemPriceDto price &&
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
