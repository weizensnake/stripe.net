using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe;
using Stripe.Infrastructure;

namespace Stripe
{
    //Part of our implementation of the StripeAccountService functionality that is currently missing in Stripe.net.
    public class StripeAddressOptions
    {
        [JsonProperty( "line1" )]
        public string AddressLine1 { get; set; }

        [JsonProperty( "line2" )]
        public string AddressLine2 { get; set; }

        [JsonProperty( "city" )]
        public string City { get; set; }

        [JsonProperty( "state" )]
        public string State { get; set; }

        [JsonProperty( "postal_code" )]
        public string PostalCode { get; set; }

        [JsonProperty( "country" )]
        public string Country { get; set; }
    }
}
