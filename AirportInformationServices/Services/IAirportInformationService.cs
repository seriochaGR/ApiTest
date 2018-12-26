using AirportInformationServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportInformationServices.Services
{
    public interface IAirportInformationService
    {
        List<Airport> GetAllAirports();

        List<Airport> GetAirportsByCountry(string country);
    }
}
