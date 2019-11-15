using Newtonsoft.Json;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Identifiers
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "usEIN")]
        public string USEmployerIdentificationNumber { get; set; }

    }

}