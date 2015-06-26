using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeApplicationFeeRefundCreateOptions
    {
        [JsonProperty( "id" )]
        public string ApplicationFeeId { get; set; }

        [JsonProperty( "amount" )]
        public int? Amount { get; set; }

        [JsonProperty( "metadata" )]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
