using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe;
using Stripe.Infrastructure;

namespace Stripe
{
    //Part of our implementation of the StripeAccountService functionality that is currently missing in Stripe.net.
    public class StripeTOSAcceptanceOptions
    {
        public DateTime? Date { get; set; }

        [JsonProperty( "date" )]
        internal long? DateInternal
        {
            get
            {
                if( !Date.HasValue ) return null;

                return EpochTime.ConvertDateTimeToEpoch( Date.Value );
            }
        }

        [JsonProperty( "ip" )]
        public string IPAddress { get; set; }

        [JsonProperty( "user_agent" )]
        public string UserAgent { get; set; }
    }
}
