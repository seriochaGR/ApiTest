using AirportInformation.Api.Client.RestObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirportInformation.Api.Client.RequestActions
{
    internal interface IAirportInformationClientServices
    {
        Task<IReadOnlyList<RestAirport>> GetAllAirportsInformation();
    }
}
