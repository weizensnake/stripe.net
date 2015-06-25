using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferReversalCreateOptions
    {
        [JsonProperty( "amount" )]
        public int Amount { get; set; }

        [JsonProperty( "currency" )]
        public string Currency { get; set; }

        [JsonProperty( "transfer_id" )]
        public string TransferId { get; set; }

        [JsonProperty( "metadata" )]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
