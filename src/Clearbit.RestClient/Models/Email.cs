namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Email
    {

        /// <summary>
        /// 
        /// </summary>
        public bool Valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool SocialMatch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool CompanyMatch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool NameMatch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Disposable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool FreeProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Blacklisted { get; set; }

    }

}