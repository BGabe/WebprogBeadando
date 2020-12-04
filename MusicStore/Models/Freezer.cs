using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Freezer:HouseHoldAppliances
    {
        public int FreezerTonnage { get; set; }
        public bool QuickFreeze { get; set; }
        public Freezer(int freezerT, bool quickfreeze)
        {
            FreezerTonnage = freezerT;
            QuickFreeze = quickfreeze;
        
        }
    }
}