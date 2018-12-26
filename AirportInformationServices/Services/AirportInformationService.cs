using AirportInformationServices.Contracts;
using AirportInformationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportInformationServices.Services
{
    public class AirportInformationService : IAirportInformationService
    {
        private IAirportInformationClient airportInformation;

        public AirportInformationService(IAirportInformationClient airportInformation)
        {
            this.airportInformation = airportInformation;            
        }

        public List<Airport> GetAllAirports()
        {
            var result = airportInformation.GetAllAirportsInformation();
            return result;
        }

        public List<Airport> GetAirportsByCountry(string country)
        {
            var result = airportInformation.GetAllAirportsInformation();
            return result.Where(a => a.Iso.Equals(country)).ToList();
        }
    }
}
