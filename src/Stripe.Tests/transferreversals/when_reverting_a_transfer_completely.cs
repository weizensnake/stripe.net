using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_reverting_a_transfer_completely
    {        
        protected static StripeTransferReversal StripeTransferReversal;
        protected static StripeTransferReversalCreateOptions StripeTransferReversalCreateOptions;
        private static StripeTransferReversalService _stripeTransferReversalService;
        private static StripeTransfer _stripeTransfer;

        Establish context = () =>
        {
            _stripeTransferReversalService = new StripeTransferReversalService();

            StripeTransferService transferService = new StripeTransferService();
            _stripeTransfer = transferService.Create( test_data.stripe_transfer_create_options.Valid() );

            StripeTransferReversalCreateOptions = test_data.stripe_transfer_reversal_create_options.CompleteReversal( _stripeTransfer );
        };

        Because of = () =>
            StripeTransferReversal = _stripeTransferReversalService.Create( StripeTransferReversalCreateOptions );

        It should_have_an_id = () =>
            StripeTransferReversal.Id.ShouldNotBeNull();

        It should_have_the_correct_amount = () =>
            StripeTransferReversal.Amount.ShouldEqual( _stripeTransfer.Amount );

        It should_have_the_correct_currency = () =>
            StripeTransferReversal.Currency.ShouldEqual( _stripeTransfer.Currency );

        It should_have_the_correct_transfer_id = () =>
            StripeTransferReversal.TransferId.ShouldEqual( _stripeTransfer.Id );
    }
}
