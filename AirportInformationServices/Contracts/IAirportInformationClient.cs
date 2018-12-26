using AirportInformationServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportInformationServices.Contracts
{
    public interface IAirportInformationClient
    {
        List<Airport> GetAllAirportsInformation();
    }
}
