using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportInformation.DTO
{
    public class GeoCoordinateDTO
    {
        public GeoCoordinateDTO(double lon, double lat)
        {
            Lon = lon;
            Lat = lat;
        }

        public double Lon { get; set; }

        public double Lat { get; set; }
    }
}
