using System;
using System.Collections.Generic;
using System.Text;

namespace AirportInformationServices.Models
{
    public class GeoCoordinate
    {
        public GeoCoordinate(double lon, double lat)
        {
            Lon = lon;
            Lat = lat;
        }

        public double Lon { get; set; }

        public double Lat { get; set; }
    }
}
