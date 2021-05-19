using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm2CApi.Entities.Mapping
{
    public interface IFarm2CEntities
    {
         DbSet<Item> Items { get; set; }

        DbSet<ItemPrice> ItemPrices { get; set; }

        DbSet<ItemCategory> ItemCategorys { get; set; }

        DbSet<Units> Units { get; set; }

        DbSet<Quantity> Quantity { get; set; }
    }
}
