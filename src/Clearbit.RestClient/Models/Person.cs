using Newtonsoft.Json;
using System;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Person
    {

        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PersonName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

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
        public string Bio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Site { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Employment Employment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Facebook Facebook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "github")]
        public GitHub GitHub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Twitter Twitter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "linkedin")]
        public LinkedIn LinkedIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "googleplus")]
        public GooglePlus GooglePlus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Gravatar Gravatar { get; set; }

        /// <summary>
        /// Indicating whether or not the lookup is a fuzzy or exact search
        /// </summary>
        public bool Fuzzy { get; set; }

        /// <summary>
        /// Is the email domain associated with a free email provider (i.e. Gmail)?
        /// </summary>
        [JsonProperty(PropertyName = "emailProvider")]
        public bool UsesFreeEmailProvider { get; set; }

        /// <summary>
        /// The time at which we indexed this data
        /// </summary>
        public DateTime IndexedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SubRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Seniority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Verified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Company Company { get; set; }

    }

}