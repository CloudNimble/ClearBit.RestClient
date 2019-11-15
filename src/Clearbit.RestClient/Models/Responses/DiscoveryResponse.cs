using System.Collections.Generic;

namespace Clearbit.Models.Responses
{

    /// <summary>
    /// 
    /// </summary>
    public class DiscoveryResponse
    {

        /// <summary>
        /// 
        /// </summary>
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Company> Results { get; set; }

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public DiscoveryResponse()
        {
            Results = new List<Company>();
        }

        #endregion

    }

}
