using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class WashingMachine:HouseHoldAppliances
    {
        public int MaxCloth { get; set; }
        public int SpinDryer { get; set; }
        public int ProgNumber { get; set; }
        public int DryCapacity { get; set; }
        public string DryClass { get; set; }
        public bool Quickprog { get; set; }
        public bool AntiCrease { get; set; }
        public WashingMachine(int maxcloth, int spindryer, int prognumber, int drycapacity, string dryclass, bool quickprog, bool anticrease)
        {
            MaxCloth = maxcloth;
            SpinDryer = spindryer;
            ProgNumber = prognumber;
            DryCapacity = drycapacity;
            DryCapacity = drycapacity;
            DryClass = dryclass;
            Quickprog = quickprog;
            AntiCrease = anticrease;

        
        }


    }
}