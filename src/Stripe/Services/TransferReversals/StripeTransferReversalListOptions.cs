using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferReversalListOptions
    {
        [JsonProperty( "transfer_id" )]
        public string TransferId { get; set; }
    }
}
