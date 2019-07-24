using AirportInformation.Api.Client.Proxy;
using AirportInformation.Api.Client.RestObjects;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AirportInformation.Api.Client.RequestActions
{
    internal class AirportInformationClientServices : IAirportInformationClientServices
    {
        public async Task<IReadOnlyList<RestAirport>> GetAllAirportsInformation()
        {
            JsonDeserializer deserial = new JsonDeserializer();
            var RestResponse = await AirportInformationProxy.RequestManager(RestSharp.Method.GET);

            var restResultList = new List<RestAirport>();
            if (RestResponse != null && RestResponse.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception();
            }

            restResultList = deserial.Deserialize<List<RestAirport>>(RestResponse);
            return restResultList;
        }
    }
}
