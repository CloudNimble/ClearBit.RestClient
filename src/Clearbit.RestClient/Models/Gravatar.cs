using System.Collections.Generic;

namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Gravatar : SocialBase
    {

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<Url> Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Avatar> Avatars { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public Gravatar()
        {
            Avatars = new List<Avatar>();
            Urls = new List<Url>();
        }

        #endregion

    }

}