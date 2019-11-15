using Newtonsoft.Json;

namespace Clearbit.Models.Requests
{

    /// <summary>
    /// 
    /// </summary>
    public class EnrichmentPersonRequest : EnrichmentRequestBase
    {

        #region Public Properties

        /// <summary>
        /// The email address to look up.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// First name of person.
        /// </summary>
        [JsonProperty(PropertyName = "given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// Last name of person. If you have this, passing this is strongly recommended to improve match rates.
        /// </summary>
        [JsonProperty(PropertyName = "family_name")]
        public string FamilyName { get; set; }

        /// <summary>
        /// IP address of the person. If you have this, passing this is strongly recommended to improve match rates.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string IPAddress { get; set; }

        /// <summary>
        /// The city or country where the person resides.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The name of the person’s employer.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public string CompanyName { get; set; }

        /// <summary>
        /// The domain for the person’s employer.
        /// </summary>
        [JsonProperty(PropertyName = "compaany_domain")]
        public string CompanyDomain { get; set; }

        /// <summary>
        /// The LinkedIn URL for the person.
        /// </summary>
        [JsonProperty(PropertyName = "linkedin")]
        public string LinkedInHandle { get; set; }

        /// <summary>
        /// The Twitter handle for the person.
        /// </summary>
        [JsonProperty(PropertyName = "twitter")]
        public string TwitterHandle { get; set; }

        /// <summary>
        /// The Facebook URL for the person.
        /// </summary>
        [JsonProperty(PropertyName = "facebook")]
        public string FacebookHandle { get; set; }

        /// <summary>
        /// Set to true to subscribe to the changes to the person.
        /// </summary>
        public bool Subscribe { get; set; }

        /// <summary>
        /// Set to eu to exclude person records with country data in the EU. Set to eu_strict to exclude person records with country data in the EU or with null country data.
        /// </summary>
        public string Suppression { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        public EnrichmentPersonRequest(string email)
        {
            Email = email;
        }

        #endregion

    }

}
