using System;

namespace Clearbit.Models.Responses
{

    /// <summary>
    /// 
    /// </summary>
    public class RiskResponse
    {

        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Live { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Fingerprint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Email Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IP Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RiskDetails Risk { get; set; }

    }

}