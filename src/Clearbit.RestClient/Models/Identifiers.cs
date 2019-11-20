using Newtonsoft.Json;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Identifiers
    {

        /// <summary>
        /// US Employer Identification Number
        /// </summary>
        [JsonProperty(PropertyName = "usEIN")]
        public string USEmployerIdentificationNumber { get; set; }

    }

}