using AirportInformationServices.Contracts;
using AirportInformationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportInformationServices.Services
{
    public class AirportInformationService : IAirportInformationService
    {
        private IAirportInformationClient airportInformation;

        public AirportInformationService(IAirportInformationClient airportInformation)
        {
            this.airportInformation = airportInformation;            
        }

        public async Task<IReadOnlyList<Airport>> GetAllAirports()
        {
            var result = await airportInformation.GetAllAirportsInformation();
            return result;
        }

        public async Task<IReadOnlyList<Airport>> GetAirportsByCountry(string country)
        {
            var result = await airportInformation.GetAllAirportsInformation();
            return result.Where(a => a.Iso.Equals(country)).ToList();
        }
    }
}
