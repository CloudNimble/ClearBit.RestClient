namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Twitter : SocialBase
    {

        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Bio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Followers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Following { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Site { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Avatar { get; set; }

    }

}