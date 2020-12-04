using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Fridge:HouseHoldAppliances
    {
        public string Externaldimensions { get; set; }
        public int Tonnage { get; set; }
        public int Refrigeratorcapacity { get; set; }
        public int FreezerCapacity { get; set; }
        public int Weight { get; set; }
        public string Technology { get; set; }
        public Fridge(string externalD, int tonnage, int refrigeratorC, int freezerC, int weight, string technology)
        {
            Externaldimensions = externalD;
            Tonnage = tonnage;
            Refrigeratorcapacity = refrigeratorC;
            FreezerCapacity = freezerC;
            Weight = weight;
            Technology = technology;


        }
    }
    
}