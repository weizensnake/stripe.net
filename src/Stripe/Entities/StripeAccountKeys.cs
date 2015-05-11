﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountKeys
    {
        [JsonProperty( "publishable" )]
        public string Publishable { get; set; }

        [JsonProperty( "secret" )]
        public string Secret { get; set; }
    }
}
