using System;
using System.Collections.Generic;

namespace Farm2CApi.Dtos
{
    public class ItemDto
    {
     
        public int ItemID { get; set; }

        public int ItemCategoryID { get; set; }

        public string ItemName { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public int UnitID { get; set; }

        public byte[] ItemImage { get; set; }

        public List<ItemPriceDto> ListItemPrice { get; set; }

    }
}
