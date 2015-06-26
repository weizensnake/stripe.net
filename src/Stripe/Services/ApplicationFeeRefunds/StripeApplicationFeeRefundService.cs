using System;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeApplicationFeeRefundService : StripeService
    {
        public StripeApplicationFeeRefundService( string apiKey = null ) : base( apiKey ) { }
        
        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeApplicationFeeRefund Create( StripeApplicationFeeRefundCreateOptions createOptions )
        {
            var url = string.Format( "{0}/{1}/refunds", Urls.ApplicationFees, createOptions.ApplicationFeeId );
            url = this.ApplyAllParameters( null, url, false );

            var response = Requestor.PostString( url, ApiKey );

            return Mapper<StripeApplicationFeeRefund>.MapFromJson( response );
        }

        public virtual StripeApplicationFeeRefund Get( string feeId, string feeRefundId )
        {
            var url = string.Format( "{0}/{1}/refunds/{2}", Urls.ApplicationFees, feeId, feeRefundId );
            url = this.ApplyAllParameters( null, url, false );

            var response = Requestor.GetString( url, ApiKey );

            return Mapper<StripeApplicationFeeRefund>.MapFromJson( response );
        }

        public virtual IEnumerable<StripeApplicationFeeRefund> List( StripeApplicationFeeRefundListOptions listOptions)
        {
            var url = string.Format( "{0}/{1}/refunds", Urls.ApplicationFees, listOptions.ApplicationFeeId );
            url = this.ApplyAllParameters( null, url, false );

            var response = Requestor.GetString( url, ApiKey );

            return Mapper<StripeApplicationFeeRefund>.MapCollectionFromJson( response );
        }

        public virtual StripeApplicationFeeRefund Update( string feeId, string feeRefundId, StripeApplicationFeeRefundUpdateOptions updateOptions )
        {
            var url = string.Format( "{0}/{1}/refunds/{2}", Urls.ApplicationFees, feeId, feeRefundId );
            url = this.ApplyAllParameters( updateOptions, url, false );

            var response = Requestor.PostString( url, ApiKey );

            return Mapper<StripeApplicationFeeRefund>.MapFromJson( response );
        }
    }
}
