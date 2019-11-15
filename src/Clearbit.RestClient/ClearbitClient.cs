using Clearbit.Models;
using Clearbit.Models.Requests;
using Clearbit.Models.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PortableRest;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Clearbit
{

    /// <summary>
    /// 
    /// </summary>
    public class ClearbitClient : RestClient
    {

        #region Constants

        private const string EnrichmentCombinedUrl = "https://person{0}.clearbit.com/v2/combined/find";
        private const string EnrichmentPersonUrl = "https://person{0}.clearbit.com/v2/people/find";
        private const string EnrichmentCompanyUrl = "https://company.clearbit.com/v2/companies/find";
        private const string DiscoverySearchUrl = "https://discovery.clearbit.com/v1/companies/search";
        private const string RiskCalculationUrl = "https://risk.clearbit.com/v1/calculate";


        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        public ClearbitClient(string apiKey)
        {
            // RWM: https://www.newtonsoft.com/json/help/html/NamingStrategyCamelCase.htm
            JsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                },
                NullValueHandling = NullValueHandling.Ignore
            };
            AddHeader("Authorization", $"Bearer {apiKey}");
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The Enrichment API lets you look up person and company data based on an email or domain. For example, you could retrieve a person’s name, location 
        /// and social handles from an email. Or you could lookup a company’s location, headcount or logo based on their domain name.
        /// </summary>
        /// <param name="enrichmentRequest"></param>
        /// <param name="streaming"></param>
        /// <returns></returns>
        /// <remarks>
        /// Note: You’ll only be charged once per 30 day period for each unique request, so if you didn’t store the data properly or need to re-run a series of 
        /// requests for any reason, those won’t count against your allotment.
        /// </remarks>
        public async Task<RestResponse<CombinedResponse>> GetEnrichmentCombinedAsync(EnrichmentPersonRequest enrichmentRequest, bool streaming = false)
        {
            if (enrichmentRequest == null)
            {
                throw new ArgumentNullException(nameof(enrichmentRequest));
            }

            var request = new RestRequest(string.Format(EnrichmentCombinedUrl, streaming ? "-stream" : ""), ContentTypes.Json);
            request.AddQueryString("email", enrichmentRequest.Email);
            BuildRequestQueryString(request, enrichmentRequest, new string[] { nameof(EnrichmentPersonRequest.Email) });
            return await SendAsync<CombinedResponse>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// The Person API lets you retrieve social information associated with an email address, such as a person’s name, location and Twitter handle.
        /// </summary>
        /// <param name="enrichmentRequest"></param>
        /// <param name="streaming"></param>
        /// <returns></returns>
        public async Task<RestResponse<Person>> GetEnrichmentPersonAsync(EnrichmentPersonRequest enrichmentRequest, bool streaming = false)
        {
            if (enrichmentRequest == null)
            {
                throw new ArgumentNullException(nameof(enrichmentRequest));
            }

            var request = new RestRequest(string.Format(EnrichmentPersonUrl, streaming ? "-stream" : ""), ContentTypes.Json);
            request.AddQueryString("email", enrichmentRequest.Email);
            BuildRequestQueryString(request, enrichmentRequest, new string[] { nameof(EnrichmentPersonRequest.Email) });
            return await SendAsync<Person>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Our Company API lets you lookup company data via a domain name.
        /// </summary>
        /// <param name="enrichmentRequest"></param>
        /// <returns></returns>
        public async Task<RestResponse<Company>> GetEnrichmentCompanyAsync(EnrichmentCompanyRequest enrichmentRequest)
        {
            if (enrichmentRequest == null)
            {
                throw new ArgumentNullException(nameof(enrichmentRequest));
            }

            var request = new RestRequest(EnrichmentCompanyUrl, ContentTypes.Json);
            request.AddQueryString("domain", enrichmentRequest.CompanyDomain);
            BuildRequestQueryString(request, enrichmentRequest, new string[] { nameof(EnrichmentCompanyRequest.CompanyDomain) });
            return await SendAsync<Company>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Our Discovery API lets you search for companies via specific criteria. For example, you could search for all companies with a specific funding, 
        /// that use a certain technology, or that are similar to your existing customers.
        /// </summary>
        /// <param name="discoveryRequest"></param>
        /// <returns></returns>
        public async Task<RestResponse<DiscoveryResponse>> GetDiscoverySearchAsync(DiscoveryRequest discoveryRequest)
        {
            if (discoveryRequest == null)
            {
                throw new ArgumentNullException(nameof(discoveryRequest));
            }

            var request = new RestRequest(DiscoverySearchUrl, ContentTypes.Json);
            request.AddQueryString("query", discoveryRequest.Query);
            BuildRequestQueryString(request, discoveryRequest, new string[] { nameof(DiscoveryRequest.Query) });
            return await SendAsync<DiscoveryResponse>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Our Discovery API lets you search for companies via specific criteria. For example, you could search for all companies with a specific funding, 
        /// that use a certain technology, or that are similar to your existing customers.
        /// </summary>
        /// <param name="riskRequest"></param>
        /// <returns></returns>
        public async Task<RestResponse<RiskResponse>> GetRiskCalculationAsync(RiskRequest riskRequest)
        {
            if (riskRequest == null)
            {
                throw new ArgumentNullException(nameof(riskRequest));
            }

            var request = new RestRequest(RiskCalculationUrl, ContentTypes.Json);
            request.AddParameter(riskRequest);
            return await SendAsync<RiskResponse>(request).ConfigureAwait(false);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="requestPayload"></param>
        /// <param name="propertiesToIgnore"></param>
        internal void BuildRequestQueryString<T>(RestRequest request, T requestPayload, string[] propertiesToIgnore) where T : class
        {
            foreach (var propertyInfo in typeof(T).GetTypeInfo().DeclaredProperties.Where(c => !propertiesToIgnore.Contains(c.Name)))
            {
                var currentValue = propertyInfo.GetValue(requestPayload);
                if (currentValue == null) continue;
                var jsonAttribute = propertyInfo.GetCustomAttributes().OfType<JsonPropertyAttribute>().FirstOrDefault();
                request.AddQueryString(jsonAttribute != null ? jsonAttribute.PropertyName : propertyInfo.Name, currentValue);
            }
        }

        #endregion

    }

}
