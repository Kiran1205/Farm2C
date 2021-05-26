using AutoMapper;
using Farm2CApi.Dtos;
using Farm2CApi.Entities;
using System.Collections.Generic;

namespace Farm2CApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Item, ItemDto>();
            CreateMap<ItemDto, Item>();

            CreateMap<ItemPriceDto, ItemPrice>();
            CreateMap<ItemPrice, ItemPriceDto>();

            CreateMap<UnitsDto, Units>();
            CreateMap<Units, UnitsDto>();

            CreateMap<QuantityDto, Quantity>();
            CreateMap<Quantity, QuantityDto>();

            CreateMap<UserInfoDto, UserInfo>();
            CreateMap<UserInfo, UserInfoDto>();

            CreateMap<UserBasket, UserBasketDto>();
            CreateMap<UserBasketDto, UserBasket>();

           CreateMap<UserAddress, UserAddressDto>();
            CreateMap<UserAddressDto, UserAddress>();
        }

    }
}
