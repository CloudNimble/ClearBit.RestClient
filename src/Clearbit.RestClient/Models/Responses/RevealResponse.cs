using Newtonsoft.Json;

namespace Clearbit.Models.Responses
{

    /// <summary>
    /// 
    /// </summary>
    public class RevealResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string IP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Fuzzy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Company Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Geo GeoIP { get; set; }

    }

}