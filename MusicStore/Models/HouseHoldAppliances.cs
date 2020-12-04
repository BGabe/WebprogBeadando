using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Models
{
    
    
   abstract public class HouseHoldAppliances
    {
        
        public string EnergyClass { get; set; }
        [DisplayName("Type")]
        public int Height { get; set; }

        [DisplayName("Artist")]
        public int Width { get; set; }
        public int Deepness { get; set; }
        public int NoiseLevel { get; set; }
        public string Colors { get; set; }
        public string Type { get; set; }
        public int Guarantee { get; set; }
        public int EnergyConsumption { get; set; }

        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(160)]
        
        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        [DisplayName("Album Art URL")]
        [StringLength(1024)]
        
       
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}