using Farm2CApi.Dtos;
using System.Collections.Generic;

namespace Farm2CApi.Service.Interface
{
    public interface IHomeService
    {
        List<ItemCategoryDto> GetBasketItems();

        ItemDto SaveItem(ItemDto itemsDto);

        BasketDto GetBasketSelectedItems(List<string> itemPriceList);
    }
}
