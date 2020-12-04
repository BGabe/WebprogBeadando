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
        public AirConditioner(int coolpower, int recommend, int airtransport)
        {
            CoolPower = coolpower;
            RecommendSpace = recommend;
            AirTransport = airtransport;

        }
    }
}