using System;
using System.Collections.Generic;
using System.Text;

namespace AirportInformationServices.Models.Exceptions
{
    [Serializable]
    public class AirportInformationClientException : Exception
    {
        public int ErrorCode { get; set; }

        public AirportInformationClientException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
