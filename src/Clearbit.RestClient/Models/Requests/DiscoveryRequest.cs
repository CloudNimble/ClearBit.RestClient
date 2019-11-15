using Newtonsoft.Json;

namespace Clearbit.Models.Requests
{

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>Please see https://clearbit.com/docs#discovery-api-request for more information.</remarks>
    public class DiscoveryRequest
    {

        /// <summary>
        /// 
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "webhook_url")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sort { get; set; }

    }
}
