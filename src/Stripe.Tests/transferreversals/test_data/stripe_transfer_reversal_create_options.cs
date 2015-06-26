using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public class stripe_transfer_reversal_create_options
    {
        public static StripeTransferReversalCreateOptions CompleteReversal( StripeTransfer transfer )
        {
            StripeTransferReversalCreateOptions stripeTransferReversalCreateOptions = new StripeTransferReversalCreateOptions()
            {
                Amount = transfer.Amount,
                Currency = transfer.Currency,
                TransferId = transfer.Id,
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };

            return stripeTransferReversalCreateOptions;
        }
    }
}
