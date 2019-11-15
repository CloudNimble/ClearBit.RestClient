using Newtonsoft.Json;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Geo
    {

        /// <summary>
        /// 
        /// </summary>
        public string StreetNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object SubPremise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StateCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "lat")]
        public float Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "lng")]
        public float Longitude { get; set; }

    }

}