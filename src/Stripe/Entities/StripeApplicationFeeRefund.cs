﻿using Newtonsoft.Json;
using Stripe.Infrastructure;
using System;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeApplicationFeeRefund
    {
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

        [JsonProperty( "fee" )]
        public string ApplicationFeeId { get; set; }

        [JsonProperty( "metadata" )]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
