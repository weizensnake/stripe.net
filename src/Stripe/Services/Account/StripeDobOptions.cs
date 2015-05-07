using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe;
using Stripe.Infrastructure;

namespace Stripe
{
    //Part of our implementation of the StripeAccountService functionality that is currently missing in Stripe.net.
    public class StripeDobOptions
    {
        [JsonProperty( "day" )]
        public int Day { get; set; }

        [JsonProperty( "month" )]
        public int Month { get; set; }

        [JsonProperty( "year" )]
        public int Year { get; set; }
    }
}
