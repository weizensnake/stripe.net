using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe;
using Stripe.Infrastructure;

namespace Stripe
{
    //Part of our implementation of the StripeAccountService functionality that is currently missing in Stripe.net.
    public class StripeAccountCreateOptions
    {
        [JsonProperty( "business_name" )]
        public string BusinessName { get; set; }

        [JsonProperty( "business_url" )]
        public string BusinessUrl { get; set; }

        [JsonProperty( "support_phone" )]
        public string SupportPhone { get; set; }

        [JsonProperty( "support_url" )]
        public string SupportUrl { get; set; }

        [JsonProperty( "support_email" )]
        public string SupportEmail { get; set; }

        [JsonProperty( "metadata" )]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty( "bank_account" )]
        public StripeBankAccountOptions BankAccount { get; set; }

        [JsonProperty( "debit_negative_balances" )]
        public bool? DebitNegativeBalances { get; set; }

        [JsonProperty( "managed" )]
        public bool? Managed { get; set; }

        [JsonProperty( "default_currency" )]
        public string DefaultCurrency { get; set; }

        [JsonProperty( "tos_acceptance" )]
        public StripeTOSAcceptanceOptions TOSAcceptance { get; set; }

        [JsonProperty( "legal_entity" )]
        public StripeLegalEntityOptions LegalEntity { get; set; }
    }
}
