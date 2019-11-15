using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Company
    {

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> DomainAliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Site Site { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? FoundedYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UtcOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Geo Geo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Facebook Facebook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "linkedin")]
        public LinkedIn LinkedIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Twitter Twitter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Crunchbase Crunchbase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool EmailProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object Ticker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Identifiers Identifiers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime IndexedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Metrics Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> Tech { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CompanyParent Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName ="ultimate_parent")]
        public CompanyParent UltimateParent { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public Company()
        {
            DomainAliases = new List<string>();
            Tags = new List<string>();
            Tech = new List<string>();
        }

        #endregion

    }

}