using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MusicStore.Models;

namespace MusicStore.EntityContext
{
   
    public class SampleData : DropCreateDatabaseIfModelChanges<HouseHoldApplianceStoreEntities>
    {
        protected override void Seed(HouseHoldApplianceStoreEntities context)
        {


            var products = new List<Product>
            {
                new Product { Name = "Zanussi XC3", Type = "Washing Machine", Description = "placeholder", ProductImgUrl= "/Content/Images/placeholder.gif" , Price = 200},
                new Product { Name = "Whirlpool Qk3", Type = "Washing Machine", Description = "placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 300 },
                new Product { Name = "Samsung CX1", Type = "Dishwasher", Description = "placeholder", ProductImgUrl ="/Content/Images/placeholder.gif", Price =250 },
                new Product { Name = "Gorenje 21", Type = "Washing Machine",  Description = "placeholder", ProductImgUrl = "/Content/Images/placeholder.gif", Price = 300 },
                new Product { Name = "Whirlpool 3q2", Type = "Freezer", Description = "placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 400 },
                new Product { Name = "Samsung qp3", Type = "Fridge", Description = "placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 500 },
                new Product { Name = "Bosch WTM", Type = "Oven", Description = "placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 250 },
                new Product { Name = "BEKO DS", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 350 },
                new Product { Name = "Tosot Tpc ", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 410 },
                new Product { Name = "Electrolux QK3", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 210},
                new Product { Name = "Electrolux WTMS", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 300 },
                new Product { Name = "Samsung MK2", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 400 },
                new Product { Name = "Whirlpool A4", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 210 },
                new Product { Name = "Bosch qf4", Type = "Dishwasher", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 130 },
                new Product { Name = "Gorenje ZX3", Type = "Dishwasher", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 140 },
                new Product { Name = "Zanussi XYZ", Type = "Dishwasher", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif", Price = 410 },
                new Product { Name = "Beko QPC", Type = "Dishwasher", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 121 },
                new Product { Name = "Beko XTR", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 230 },
                new Product { Name = "Samsung KLR", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 340},
                new Product { Name = "BEKO CSA", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" ,Price = 450 },
                new Product { Name = "Zanussi QCR", Type = "Washing Machine", Description="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 450 },
                new Product { Name = "Samsung ZRA33", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 340 },
                new Product { Name = "Electrolux XQZ3", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif", Price = 300 },
                new Product { Name = "Tosot Tpc 2 ", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 265 },
                new Product { Name = "Hausmeister 21", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 410 },
                new Product { Name = "Hausmeister 22 ", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 155 },
                new Product { Name = "Hausmeister QBV", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 510 },
                new Product { Name = "LG 331", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 120 },
                new Product { Name = "LG 365", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 200 },
                new Product { Name = "LG 678", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 250 },
                new Product { Name = "AEG 215", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif", Price = 300 },
                new Product { Name = "Samsung 3231", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif", Price = 300 },
                new Product { Name = "AEG KLFD", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 200 },
                new Product { Name = "Beko 2123", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 120 },
                new Product { Name = "Samsung 2020", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price= 110 },
                new Product { Name = "AEG 2020", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" ,Price = 310 },
                new Product { Name = "Electrolux 2020", Type = "Dishwasher", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 300 },
                new Product { Name = "Gorenje 2020", Type = "Dishwasher", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 400 },
                new Product { Name = "Snaige 321", Type = "Dishwasher", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 410 },
                new Product { Name = "Snaige 2020", Type = "Dishwasher", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 120 },
                new Product { Name = "Snaige QWE", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 100 },
                new Product { Name = "Candy x34", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 100 },
                new Product { Name = "Candy QZT", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 100 },
                new Product { Name = "Candy 321", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 110 },
                new Product { Name = "Whirlpool 2020", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 400 },
                new Product { Name = "Bosch 2020", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 410 },
                new Product { Name = "Bosch 213im", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 515 },
                new Product { Name = "Whirlpool 2021", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 500},
                new Product { Name = "Samsung XKQW", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 330 },
                new Product { Name = "Samsung LKSD", Type = "Washing Machine", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 325 },
                new Product { Name = "Whirlpool OLAP", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 350 },
                new Product { Name = "Gorenje OLAP", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 410 },
                new Product { Name = "LG 3215", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 140 },
                new Product { Name = "Candy 1233", Type = "Oven", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 400 },
                new Product { Name = "Snaige 1233", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 410 },
                new Product { Name = "Beko 123PO", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 120 },
                new Product { Name = "Electrolux 1235PO", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 260 },
                new Product { Name = "Zanussi 329", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 250 },
                new Product { Name = "Zanussi 329PA", Type = "Fridge", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 300 },
                new Product { Name = "Hausmeister 21PA", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 310 },
                new Product { Name = "Tosot 2103", Type = "Freezer", Description ="placeholder", ProductImgUrl = "/Content/Images/placeholder.gif" , Price = 320 }

            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}