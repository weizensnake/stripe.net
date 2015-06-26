using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferReversalListOptions
    {
        [JsonProperty( "id" )]
        public string TransferId { get; set; }
    }
}
