using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.GetProducts
{
    public class GetProducts
    {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        //Azért használok IEnumerable-t hogy ne lehessen manipulálni az adatokat 
        public IEnumerable<ProductViewModel> Do() =>_ctx.Products.ToList().Select(x => new ProductViewModel 
           { 
               Name = x.Name,
               Description = x.Description,
               Price = $"{x.Price.ToString("N2")} Ft",
           });
    }
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
