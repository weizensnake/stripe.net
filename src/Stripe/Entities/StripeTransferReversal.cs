using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTransferReversal : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public StripeBalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty( "balance_transaction" )]
        internal object InternalBalanceTransaction
        {
            set
            {
                ExpandableProperty<StripeBalanceTransaction>.Map( value, s => BalanceTransactionId = s, o => BalanceTransaction = o );
            }
        }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
        
        public string TransferId { get; set; }

        [JsonIgnore]
        public StripeTransfer Transfer { get; set; }

        [JsonProperty( "transfer" )]
        internal object InternalTransfer
        {
            set
            {
                ExpandableProperty<StripeTransfer>.Map( value, s => TransferId = s, o => Transfer = o );
            }
        }
    }
}