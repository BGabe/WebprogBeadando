using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class DryMachine:HouseHoldAppliances
    {
        public int DryCapacity { get; set; }
        public string DryTechnology { get; set; }
        public int MaxCloth { get; set; }
        public DryMachine(int drycapacity, string drytechnology, int maxcloth)
        {
            DryCapacity = drycapacity;
            DryTechnology = drytechnology;
            MaxCloth = maxcloth;

        
        }
    }
}