namespace Clearbit.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Category
    {

        /// <summary>
        /// Broad sector (<a href="https://help.clearbit.com/hc/en-us/articles/115014819927-What-values-do-Clearbit-s-industry-category-attributes-return-">see a complete list</a>)
        /// </summary>
        public string Sector { get; set; }

        /// <summary>
        /// Industry group (<a href="https://help.clearbit.com/hc/en-us/articles/115014819927-What-values-do-Clearbit-s-industry-category-attributes-return-">see a complete list</a>)
        /// </summary>
        public string IndustryGroup { get; set; }

        /// <summary>
        /// Industry (<a href="https://help.clearbit.com/hc/en-us/articles/115014819927-What-values-do-Clearbit-s-industry-category-attributes-return-">see a complete list</a>)
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// Sub-industry (<a href="https://help.clearbit.com/hc/en-us/articles/115014819927-What-values-do-Clearbit-s-industry-category-attributes-return-">see a complete list</a>)
        /// </summary>
        public string SubIndustry { get; set; }

        /// <summary>
        /// Two digit category SIC code
        /// </summary>
        public string SicCode { get; set; }

        /// <summary>
        /// Two digit category NAICS code
        /// </summary>
        public string NaicsCode { get; set; }

    }

}