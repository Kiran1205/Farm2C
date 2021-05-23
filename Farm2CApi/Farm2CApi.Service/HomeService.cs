using AutoMapper;
using Farm2CApi.DataAccess.Interface;
using Farm2CApi.Dtos;
using Farm2CApi.Entities;
using Farm2CApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Farm2CApi.Service
{
    public class HomeService : IHomeService
    {
        private readonly IHomeDataAccess _ihomeDataAccess;
        private readonly IMapper _mapper;
        public HomeService(IHomeDataAccess ihomeDataAccess , IMapper mapper)
        {
            _ihomeDataAccess = ihomeDataAccess;
            _mapper = mapper;
        }

        public List<ItemCategoryDto> GetBasketItems()
        {
            List<ItemCategoryDto> itemCategoryDtos = new List<ItemCategoryDto>();

            List<ItemCategory> listofCategory = _ihomeDataAccess.GetItemCategorys();

            var qunatitys = _ihomeDataAccess.GetQuantitys();

            var units = _ihomeDataAccess.GetUnits();

            foreach (var itemCategory in listofCategory)
            {
                ItemCategoryDto  dto = new ItemCategoryDto();
                dto.CategoryName = itemCategory.CategoryName;
                dto.ItemCategoryID = itemCategory.ItemCategoryID;
                dto.Description = itemCategory.Description;

                List<Item> itemsDtos =  _ihomeDataAccess.GetItems(itemCategory.ItemCategoryID);
                dto.ItemDtoList = _mapper.Map<List<ItemDto>>(itemsDtos);

                foreach (var item in dto.ItemDtoList)
                {
                    var itemPrice = _ihomeDataAccess.GetListItemPrice(DateTime.Now, item.ItemID);
                    item.ListItemPrice = _mapper.Map<List<ItemPriceDto>>(itemPrice);
                    foreach (var price in item.ListItemPrice)
                    {
                       var selectedQty =  qunatitys.Where(x => x.QuantityID == price.QuantityID).First();
                       var selectedunit = units.Where(x => x.UnitID == selectedQty.UnitID).First();
                       price.PriceCode = selectedQty.QuantityType + " " + selectedunit.UnitName;
                    }
                }
               
                //dto.ListQunatityDto = _mapper.Map<List<QuantityDto>>(qunatitys);
                //dto.ListUnitsDto = _mapper.Map<List<UnitsDto>>(units);

                itemCategoryDtos.Add(dto);
            }

            return itemCategoryDtos;
        }

        public BasketDto GetBasketSelectedItems(List<string> itemPriceList)
        {
            var qunatitys = _ihomeDataAccess.GetQuantitys();

            var units = _ihomeDataAccess.GetUnits();

            BasketDto basketDto = new BasketDto();
           
            foreach (var priceid in itemPriceList)
            {
                BasketItemDto basketItemDto = new BasketItemDto();
                var itemPrice = _ihomeDataAccess.GettItemPriceById(Convert.ToInt32(priceid));

                var selectedQty = qunatitys.Where(x => x.QuantityID == itemPrice.QuantityID).First();
                var selectedunit = units.Where(x => x.UnitID == selectedQty.UnitID).First();

                basketItemDto.Qunatity = selectedQty.QuantityType + " " + selectedunit.UnitName;

                basketItemDto.ItemPriceId = itemPrice.ItemPriceID;
                basketItemDto.ItemId = itemPrice.ItemID;
                basketItemDto.Price = itemPrice.Price;
                basketItemDto.NoOfUInits = 1;

                var item = _ihomeDataAccess.GetItemById(itemPrice.ItemID);
                basketItemDto.Description = item.Description;
                basketItemDto.ItemImage = item.ItemImage;
                basketItemDto.ItemName = item.ItemName;
                basketDto.TotalPrice += itemPrice.Price;

                basketDto.BasketItemList.Add(basketItemDto);
            }

            return basketDto;
        }
        public ItemDto SaveItem(ItemDto itemsDto)
        {
            var result = _ihomeDataAccess.SaveItem(_mapper.Map<Item>(itemsDto));
            return _mapper.Map<ItemDto>(result);
        }
    }
}
