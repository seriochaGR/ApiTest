using AirportInformationServices.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportInformationServices.Models
{
    public class Airport
    {
        public string Iata { get; set; }        

        public string Iso { get; set; }

        public int Status { get; set; }

        public string Name { get; set; }

        public Continents Continent { get; set; }

        public AirportTypes Type { get; set; }

        public Sizes Size { get; set; }

        public GeoCoordinate Coordinate { get; set; }
    }
}
