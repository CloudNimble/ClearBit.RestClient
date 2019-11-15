using Newtonsoft.Json;

namespace Clearbit.Models.Requests
{

    /// <summary>
    /// 
    /// </summary>
    public class EnrichmentCompanyRequest : EnrichmentRequestBase
    {

        #region Public Properties

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public string CompanyName { get; set; }

        /// <summary>
        /// The domain to look up.
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string CompanyDomain { get; set; }

        /// <summary>
        /// The LinkedIn URL for the company.
        /// </summary>
        [JsonProperty(PropertyName = "linkedin")]
        public string LinkedInHandle { get; set; }

        /// <summary>
        /// The Twitter handle for the company.
        /// </summary>
        [JsonProperty(PropertyName = "twitter")]
        public string TwitterHandle { get; set; }

        /// <summary>
        /// The Facebook URL for the company.
        /// </summary>
        [JsonProperty(PropertyName = "facebook")]
        public string FacebookHandle { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyDomain"></param>
        public EnrichmentCompanyRequest(string companyDomain)
        {
            CompanyDomain = companyDomain;
        }

        #endregion

    }

}
