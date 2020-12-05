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
        [DisplayName("EnergyClass")]
        public string EnergyClass { get; set; }
        [DisplayName("Height")]
        public int Height { get; set; }
        [DisplayName("Width")]
        public int Width { get; set; }
        [DisplayName("Deepness")]
        public int Deepness { get; set; }
        [DisplayName("NoiseLevel")]
        public int NoiseLevel { get; set; }
        [DisplayName("Colors")]
        public string Color { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        [DisplayName("Guarantee")]
        public int Guarantee { get; set; }
        [DisplayName("EnergyConsumption")]
        public int EnergyConsumption { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public double Price { get; set; }
        /*
        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(160)]*/
        
        public virtual List<OrderDetail> OrderDetails { get; set; }

        public HouseHoldAppliances(string EnergyClass,int Width, int Deepness, int NoiseLevel, string Color, string Type, int Guarantee, int EnergyConsumption, double Price)
        {
            this.EnergyClass = EnergyClass;
            this.Width = Width;
            this.Deepness = Deepness;
            this.NoiseLevel = NoiseLevel;
            this.Color = Color;
            this.Type = Type;
            this.Guarantee = Guarantee;
            this.EnergyConsumption = EnergyConsumption;
            this.Price = Price;
        }
    }
}