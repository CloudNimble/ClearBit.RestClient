namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class IP
    {

        /// <summary>
        /// 
        /// </summary>
        public bool Proxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool GeoMatch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Blacklisted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool RateLimited { get; set; }

    }

}