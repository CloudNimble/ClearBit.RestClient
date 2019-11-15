using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clearbit.Models.Requests
{

    /// <summary>
    /// 
    /// </summary>
    public class EnrichmentRequestBase
    {

        /// <summary>
        /// A webhook URL that results will be sent to.
        /// </summary>
        [JsonProperty(PropertyName = "webhook_url")]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Custom identifier for the webhook request.
        /// </summary>
        [JsonProperty(PropertyName = "webhook_id")]
        public string WebhookId { get; set; }



    }

}
