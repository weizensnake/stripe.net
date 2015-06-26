using System;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeApplicationFeeRefundListOptions
    {
        [JsonProperty( "id" )]
        public string ApplicationFeeId { get; set; }
    }
}
