using System.Collections.Generic;

namespace Farm2CApi.Dtos
{
    public class ItemCategoryDto
    {
        
        public int ItemCategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; } 
        
        public List<ItemDto> ItemDtoList { get; set; }

        //public List<QuantityDto> ListQunatityDto { get; set; }

        //public List<UnitsDto> ListUnitsDto { get; set; }

    }
}
