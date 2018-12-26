using AirportInformation.Api.Client.Proxy;
using AirportInformation.Api.Client.RestObjects;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AirportInformation.Api.Client.RequestActions
{
    internal class AirportInformationClientServices : IAirportInformationClientServices
    {
        public List<RestAirport> GetAllAirportsInformation()
        {
            RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
            var RestResponse = AirportInformationProxy.RequestManager(RestSharp.Method.GET);

            List<RestAirport> restResultList = new List<RestAirport>();
            if (RestResponse != null && RestResponse.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception();
            }

            restResultList = deserial.Deserialize<List<RestAirport>>(RestResponse);
            return restResultList;
        }
    }
}
