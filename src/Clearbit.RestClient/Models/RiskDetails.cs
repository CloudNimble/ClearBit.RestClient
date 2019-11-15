using System.Collections.Generic;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class RiskDetails
    {

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> Reasons { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public RiskDetails()
        {
            Reasons = new List<string>();
        }

        #endregion

    }

}