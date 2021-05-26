using Farm2CApi.Dtos;
using System.Collections.Generic;

namespace Farm2CApi.Service.Interface
{
    public interface IHomeService
    {
        List<ItemCategoryDto> GetBasketItems();

        ItemDto SaveItem(ItemDto itemsDto);

        BasketDto GetBasketSelectedItems(int userId);
        int RemoveItemInBasket(int UserBasketID);
        List<UserBasketDto> GetBasketItems(int userId);
        UserBasketDto SaveItemInBasket(UserBasketDto userBasket);
        string PlaceOrder(int UserInfoID, int useraddressId);
    }
}
