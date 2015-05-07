using System;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountVerification
    {
        [JsonProperty( "fields_needed" )]
        public string[] FieldsNeeded { get; set; }

        [JsonProperty( "due_by" )]
        public DateTime? DueBy { get; set; }

        [JsonProperty( "contacted" )]
        public bool Contacted { get; set; }
    }
}
