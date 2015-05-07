﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccount : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currencies_supported")]
        public string[] CurrenciesSupported { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        [JsonProperty("transfers_enabled")]
        public bool TransfersEnabled { get; set; }

        [JsonProperty( "debit_negative_balances" )]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty( "decline_charge_on" )]
        public StripeDeclineChargeOn DeclineChargesOn { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty( "product_description" )]
        public string ProductDescription { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty( "support_phone" )]
        public string SupportPhone { get; set; }

        [JsonProperty( "support_email" )]
        public string SupportEmail { get; set; }

        [JsonProperty( "support_url" )]
        public string SupportUrl { get; set; }

        [JsonProperty( "support_address" )]
        public StripeAddress SupportAddress { get; set; }

        [JsonProperty( "managed" )]
        public bool Managed { get; set; }

        [JsonProperty( "legal_entity" )]
        public StripeLegalEntity LegalEntity { get; set; }

        [JsonProperty( "tos_acceptance" )]
        public StripeTOSAcceptance TOSAcceptance { get; set; }

        [JsonProperty( "verification" )]
        public StripeAccountVerification Verification { get; set; }

        [JsonProperty( "transfer_schedule" )]
        public StripeTransferSchedule TransferSchedule { get; set; }

        [JsonProperty( "bank_accounts" )]
        public StripeBankAccountList BankAccounts { get; set; }
    }
}
