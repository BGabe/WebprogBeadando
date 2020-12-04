using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class DishWasher : HouseHoldAppliances
    {
        public int ProgNumber { get; set; }
        public int DishesNumber { get; set; }
        public bool NightProg { get; set; }
        public DishWasher(int prognumber, int dishes, bool night)
        {
            ProgNumber = prognumber;
            DishesNumber = dishes;
            NightProg = night;
        
        
        }
    }
}