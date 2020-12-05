using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class AirConditioner:HouseHoldAppliances
    {
        public int CoolPower { get; set; }
        public int RecommendSpace { get; set; }
        public int AirTransport { get; set; }
        public AirConditioner(double Price,string EnergyClass, int Width, int Deepness, int NoiseLevel, string Color, string Type, int Guarantee, int EnergyConsumption, int coolpower, int recommend, int airtransport) : base(EnergyClass, Width, Deepness, NoiseLevel, Color, Type,  Guarantee, EnergyConsumption,Price)
        {
            CoolPower = coolpower;
            RecommendSpace = recommend;
            AirTransport = airtransport;

        }
    }
}