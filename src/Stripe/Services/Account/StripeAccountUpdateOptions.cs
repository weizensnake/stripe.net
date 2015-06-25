using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountUpdateOptions
    {
        [JsonProperty( "email" )]
        public string Email { get; set; }

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

        [JsonProperty( "decline_charge_on" )]
        [SerializeAsHash]
        public StripeDeclineChargeOn DeclineChargesOn { get; set; }

        [JsonProperty( "bank_account" )]
        public StripeBankAccountOptions BankAccount { get; set; }

        [JsonProperty( "debit_negative_balances" )]
        public bool? DebitNegativeBalances { get; set; }

        [JsonProperty( "default_currency" )]
        public string DefaultCurrency { get; set; }

        [JsonProperty( "tos_acceptance" )]
        [SerializeAsHash]
        public StripeTOSAcceptanceOptions TOSAcceptance { get; set; }

        [JsonProperty( "legal_entity" )]
        [SerializeAsHash]
        public StripeLegalEntityOptions LegalEntity { get; set; }

        [JsonProperty( "transfer_schedule" )]
        [SerializeAsHash]
        public StripeTransferScheduleOptions TransferSchedule { get; set; }
    }
}
