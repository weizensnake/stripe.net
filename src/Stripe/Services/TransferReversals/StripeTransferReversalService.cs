using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe
{
    public class StripeTransferReversalService : StripeService
    {
        public StripeTransferReversalService( string apiKey = null ) : base( apiKey ) { }

        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeTransferReversal Create(StripeTransferReversalCreateOptions createOptions)
        {
            var url = string.Format( "{0}/{1}/reversals", Urls.Transfers, createOptions.TransferId );
            url = this.ApplyAllParameters( null, url, false );

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeTransferReversal>.MapFromJson(response);
        }

        public virtual StripeTransferReversal Get( string transferId, string transferReversalId )
        {
            var url = string.Format( "{0}/{1}/reversals/{2}", Urls.Transfers, transferId, transferReversalId );
            url = this.ApplyAllParameters( null, url, false );

            var response = Requestor.GetString( url, ApiKey );

            return Mapper<StripeTransferReversal>.MapFromJson( response );
        }

        public virtual IEnumerable<StripeTransferReversal> List( StripeTransferReversalListOptions listOptions = null )
        {
            var url = string.Format( "{0}/{1}/reversals", Urls.Transfers, listOptions.TransferId );
            url = this.ApplyAllParameters( null, url, false );

            var response = Requestor.GetString( url, ApiKey );

            return Mapper<StripeTransferReversal>.MapCollectionFromJson( response );
        }
    }
}
