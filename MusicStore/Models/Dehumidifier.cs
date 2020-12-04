using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Dehumidifier:HouseHoldAppliances
    {
        public int MaxAirTransport { get; set; }
        public int OutletPipe { get; set; }
        public string Illumination { get; set; }
        public string Extractor { get; set; }
        public Dehumidifier(int maxair, int outlet, string illu, string extract)
        {
            MaxAirTransport = maxair;
            OutletPipe = outlet;
            Illumination = illu;
            Extractor = extract;
        
        }
    }
}