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
            var results = _idapper.GetAll<Units>("select * from dbo.Units where Active = 'true'", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public List<Item> GetItems()
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<Item>("select * from dbo.Items where Active = 'true'", dbparams, System.Data.CommandType.Text);
            return results;
        }
        public Item GetItemById(int ItemId)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.Get<Item>($"select * from dbo.Items where Active = 'true' and  ItemID = {ItemId}", dbparams, System.Data.CommandType.Text);
            return results;
        }
        public List<Item> GetItems(int itemCategoryID)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<Item>($"select * from dbo.Items where Active = 'true' and ItemCategoryId = {itemCategoryID}", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public List<ItemCategory> GetItemCategorys()
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<ItemCategory>("select * from dbo.ItemCategory where Active = 'true'", dbparams, System.Data.CommandType.Text);
            return results;
        }
        public List<ItemPrice> GetListItemPrice(DateTime currentDate, int ItemId)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<ItemPrice>($"select * from dbo.ItemPrice where ItemID = {ItemId} and '{currentDate:yyyy-MM-dd}' between StartDate and EndDate", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public ItemPrice GettItemPriceById(int ItemPriceId)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.Get<ItemPrice>($"select * from dbo.ItemPrice where ItemPriceId = {ItemPriceId}", dbparams, System.Data.CommandType.Text);
            return results;
        }


        public List<Quantity> GetQuantitys()
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<Quantity>("select * from dbo.Quantity", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public Item SaveItem(Item itemsDto)
        {
            _farm2CEntities.Items.Add(itemsDto);
            _farm2CEntities.SaveChanges();
            return itemsDto;
        }

        public UserBasket SaveItemInBasket(UserBasket userBasket)
        {
            _farm2CEntities.UserBasket.Add(userBasket);
            _farm2CEntities.SaveChanges();
            return userBasket;
        }
        public List<UserBasket> GetBasketCount(int userId)
        {
            DynamicParameters dbparams = new DynamicParameters();
            var results = _idapper.GetAll<UserBasket>($"select * from dbo.UserBasket where UserInfoID = {userId}", dbparams, System.Data.CommandType.Text);
            return results;
        }

        public int RemoveItemInBasket(int userBasketId)
        {
            DynamicParameters dbparams = new DynamicParameters();
            return _idapper.Execute($"delete from dbo.UserBasket where UserBasketID = {userBasketId};", dbparams, System.Data.CommandType.Text);         
        }
        public void RemoveItemInBasketByUserId(int userId)
        {
            DynamicParameters dbparams = new DynamicParameters();
             _idapper.Execute($"delete from dbo.UserBasket where UserInfoID = {userId};", dbparams, System.Data.CommandType.Text);
        }
        public Invoice SaveInvoice(Invoice invoice)
        {
            _farm2CEntities.Invoice.Add(invoice);
            _farm2CEntities.SaveChanges();
            return invoice;
        }
        public void SaveInvoiceItemList(List<InvoiceItemList> invoicelist)
        {
            _farm2CEntities.InvoiceItemList.AddRange(invoicelist);
            _farm2CEntities.SaveChanges();
        }
    }
}