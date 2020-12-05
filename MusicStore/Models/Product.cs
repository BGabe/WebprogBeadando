using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Models
{

    [Bind(Exclude = "ProductId")]
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("ProductImgUrl")]
        public string ProductImgUrl { get; set; }
        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}