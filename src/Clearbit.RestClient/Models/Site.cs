using System.Collections.Generic;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Site
    {

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> EmailAddresses { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public Site()
        {
            PhoneNumbers = new List<string>();
            EmailAddresses = new List<string>();
        }

        #endregion

    }

}