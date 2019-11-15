namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class GitHub : SocialBase
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
        public string Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Blog { get; set; }

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
        public int? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Favorites { get; set; }

    }

}