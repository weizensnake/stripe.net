using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe;
using Stripe.Infrastructure;

namespace Stripe
{
    //Part of our implementation of the StripeAccountService functionality that is currently missing in Stripe.net.
    public class StripeLegalEntityOptions
    {
        [JsonProperty( "type" )]
        public string Type { get; set; }

        [JsonProperty( "business_name" )]
        public string BusinessName { get; set; }

        [JsonProperty( "business_tax_id" )]
        public string BusinessTaxId { get; set; }

        [JsonProperty( "business_vat_id" )]
        public string BusinessVATId { get; set; }

        [JsonProperty( "personal_id_number" )]
        public string PersonalIdNumber { get; set; }

        [JsonProperty( "ssn_last_4" )]
        public string SSNLastFourDigits { get; set; }

        [JsonProperty( "first_name" )]
        public string FirstName { get; set; }

        [JsonProperty( "last_name" )]
        public string LastName { get; set; }

        [JsonProperty( "dob" )]
        [SerializeAsHash]
        public StripeDobOptions DOB { get; set; }

        [JsonProperty( "address" )]
        [SerializeAsHash]
        public StripeAddressOptions Address { get; set; }

        [JsonProperty( "pesonal_address" )]
        [SerializeAsHash]
        public StripeAddressOptions PersonalAddress { get; set; }
    }
}
