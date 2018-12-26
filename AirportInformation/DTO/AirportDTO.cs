using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportInformation.DTO
{
    public class AirportDTO
    {
        public string Iata { get; set; }

        public string Iso { get; set; }

        public int Status { get; set; }

        public string Name { get; set; }

        public string Continent { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public GeoCoordinateDTO Coordinate { get; set; }
    }
}
