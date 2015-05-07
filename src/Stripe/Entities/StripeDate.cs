using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDate
    {
        [JsonProperty( "day" )]
        public string Day { get; set; }

        [JsonProperty( "month" )]
        public string Month { get; set; }

        [JsonProperty( "year" )]
        public string Year { get; set; }
    }
}
