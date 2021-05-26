using System.Collections.Generic;

namespace Farm2CApi.Dtos
{
    public class BasketItemDto
    {
        public int UserBasketID { get; set; }
        public int ItemPriceId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public byte[] ItemImage{ get; set; }
        public string Description{ get; set; }
        public double Price { get; set; }

        public string Qunatity { get; set; }

        public int NoOfUInits { get; set; }
       

    }
    public class BasketDto
    {
       public List<BasketItemDto> BasketItemList { get; set; }

       public double TotalPrice { get; set; }

        public BasketDto()
        {
            BasketItemList = new List<BasketItemDto>();
        }

    }
}
