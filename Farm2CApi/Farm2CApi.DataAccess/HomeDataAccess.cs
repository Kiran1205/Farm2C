using Dapper;
using Farm2CApi.DataAccess.Interface;
using Farm2CApi.Entities;
using Farm2CApi.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data;

namespace Farm2CApi.DataAccess
{
    public class HomeDataAccess : IHomeDataAccess
    {
        public  IDapper _idapper;
        private readonly Farm2CEntities _farm2CEntities;
        public HomeDataAccess(IDapper idrapper, Farm2CEntities _context)
        {
            _farm2CEntities = _context;
            _idapper = idrapper;
        }

        public List<Units> GetUnits()
        {
            DynamicParameters dbparams = new DynamicParameters();          
            var results = _idapper.GetAll<Units>("select * from Units where Active = 'true'", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public List<Item> GetItems()
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<Item>("select * from Items where Active = 'true'", dbparams, System.Data.CommandType.Text);
            return results;
        }
        public List<Item> GetItems(int itemCategoryID)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<Item>($"select * from Items where Active = 'true' and ItemCategoryId = {itemCategoryID}", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public List<ItemCategory> GetItemCategorys()
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<ItemCategory>("select * from ItemCategory where Active = 'true'", dbparams, System.Data.CommandType.Text);
            return results;
        }
        public List<ItemPrice> GetListItemPrice(DateTime currentDate, int ItemId)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<ItemPrice>($"select * from ItemPrice where ItemID = {ItemId} and {currentDate} between StartDate and EndDate", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public List<Quantity> GetQuantitys()
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<Quantity>("select * from Quantity", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public Item SaveItem(Item itemsDto)
        {
            _farm2CEntities.Items.Add(itemsDto);
            _farm2CEntities.SaveChanges();
            return itemsDto;
        }

    }
}