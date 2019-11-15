using Newtonsoft.Json;

namespace Clearbit.Models.Requests
{

    /// <summary>
    /// Our Risk API takes an email and IP and calculates an associated risk score. This is especially useful for figuring out 
    /// whether incoming signups to your service are spam or legitimate, or whether a payment has a high chargeback risk.
    /// </summary>
    public class RiskRequest
    {

        #region Public Properties

        /// <summary>
        /// (required) Email address to calculate score against.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// (required) IP address to calculate score against.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string IPAddress { get; set; }

        /// <summary>
        /// (strongly recommended) Person’s two letter country code.
        /// </summary>
        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// (strongly recommended) Person’s postal/zip code
        /// </summary>
        [JsonProperty(PropertyName = "zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// (strongly recommended) Person’s first name.
        /// </summary>
        [JsonProperty(PropertyName = "given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// (strongly recommended) Person’s last name.
        /// </summary>
        [JsonProperty(PropertyName = "family_name")]
        public string FamilyName { get; set; }

        /// <summary>
        /// (optional) Alternative to passing in a separate given_name and family_name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="ip"></param>
        public RiskRequest(string email, string ip)
        {
            Email = email;
            IPAddress = ip;
        }

        #endregion

    }

}
