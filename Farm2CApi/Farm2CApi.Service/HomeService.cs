using AutoMapper;
using Farm2CApi.DataAccess.Interface;
using Farm2CApi.Dtos;
using Farm2CApi.Entities;
using Farm2CApi.Service.Interface;
using System;
using System.Collections.Generic;

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
                }
               
                dto.ListQunatityDto = _mapper.Map<List<QuantityDto>>(qunatitys);
                dto.ListUnitsDto = _mapper.Map<List<UnitsDto>>(units);

                itemCategoryDtos.Add(dto);
            }

            return itemCategoryDtos;
        }

        public ItemDto SaveItem(ItemDto itemsDto)
        {
            var result = _ihomeDataAccess.SaveItem(_mapper.Map<Item>(itemsDto));
            return _mapper.Map<ItemDto>(result);
        }
    }
}
