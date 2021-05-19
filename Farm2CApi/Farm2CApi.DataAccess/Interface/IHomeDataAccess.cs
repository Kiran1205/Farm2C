using Farm2CApi.Entities;
using System;
using System.Collections.Generic;

namespace Farm2CApi.DataAccess.Interface
{
    public interface IHomeDataAccess 
    {
        List<Units> GetUnits();

        List<Item> GetItems();

        List<Item> GetItems(int itemCategoryID);

        List<ItemCategory> GetItemCategorys();

        List<ItemPrice> GetListItemPrice(DateTime currentDate, int ItemId);

        List<Quantity> GetQuantitys();

        Item SaveItem(Item itemsDto);
    }
}
