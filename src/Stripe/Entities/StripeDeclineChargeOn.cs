using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDeclineChargeOn
    {
        [JsonProperty( "cvc_failure" )]
        public bool? CvcFailure { get; set; }

        [JsonProperty( "avs_failure" )]
        public bool? AvsFailure { get; set; }
    }
}
