using Newtonsoft.Json;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Metrics
    {

        /// <summary>
        /// Alexa’s US site rank
        /// </summary>
        public int? AlexaUsRank { get; set; }

        /// <summary>
        /// Alexa’s global site rank
        /// </summary>
        public int? AlexaGlobalRank { get; set; }

        /// <summary>
        /// Number of employees
        /// </summary>
        [JsonProperty(PropertyName = "employees")]
        public int? EmployeeCount { get; set; }

        /// <summary>
        /// Employees range (<a href="https://help.clearbit.com/hc/en-us/articles/115015447087-What-are-the-Employee-Ranges-returned-by-Enrichment-">see a complete list</a>)
        /// </summary>
        public string EmployeesRange { get; set; }

        /// <summary>
        /// Estimated market capitalization
        /// </summary>
        public object MarketCap { get; set; }

        /// <summary>
        /// Total amount raised.
        /// </summary>
        [JsonProperty(PropertyName = "raised")]
        public long? CapitalRaised { get; set; }

        /// <summary>
        /// Annual Revenue (public companies only).
        /// </summary>
        public object AnnualRevenue { get; set; }

        /// <summary>
        /// Estimated annual revenue range (<a href="https://help.clearbit.com/hc/en-us/articles/115015447027-What-are-the-Estimated-Annual-Revenue-ranges-returned-by-Enrichment-">see a complete list</a>)
        /// </summary>
        public string EstimatedAnnualRevenue { get; set; }

        /// <summary>
        /// Month that the fiscal year ends (1-indexed)
        /// </summary>
        public int? FiscalYearEnd { get; set; }

    }

}