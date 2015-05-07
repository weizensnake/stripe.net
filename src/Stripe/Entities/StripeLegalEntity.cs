using Newtonsoft.Json;

namespace Stripe
{
    public class StripeLegalEntity
    {
        [JsonProperty( "type" )]
        public string Type { get; set; }

        [JsonProperty( "business_name" )]
        public string BusinessName { get; set; }

        [JsonProperty( "address" )]
        public StripeAddress Address { get; set; }

        [JsonProperty( "first_name" )]
        public string FirstName { get; set; }

        [JsonProperty( "last_name" )]
        public string LastName { get; set; }

        [JsonProperty( "personal_address" )]
        public StripeAddress PersonalAddress { get; set; }

        [JsonProperty( "dob" )]
        public StripeDate DOB { get; set; }

        [JsonProperty( "additional_owners" )]
        public string[] AdditionalOwners { get; set; }

        [JsonProperty( "verification" )]
        public StripeLegalEntityVerification Verification { get; set; }
    }
}
