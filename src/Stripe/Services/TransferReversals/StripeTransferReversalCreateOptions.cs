﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferReversalCreateOptions
    {
        [JsonProperty( "amount" )]
        public int? Amount { get; set; }

        [JsonProperty( "id" )]
        public string TransferId { get; set; }

        [JsonProperty( "refund_application_fee" )]
        public bool RefundApplicationFee { get; set; }

        [JsonProperty( "metadata" )]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty( "description" )]
        public string Description { get; set; }
    }
}
