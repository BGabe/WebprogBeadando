using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.EntityContext
{
    public class HouseHoldApplianceStoreEntities : DbContext
    {



        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        //javít autentikációhoz
        public DbSet<Mvc3ToolsUpdateWeb_Default.Models.LogOnModel> logOnModels { get; set; }

        public HouseHoldApplianceStoreEntities()
        {

        }
    }
}