﻿using System;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeApplicationFeeService : StripeService
    {
        public StripeApplicationFeeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandAccount { get; set; }
        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandCharge { get; set; }

        public virtual StripeApplicationFee Get(string applicationFeeId)
        {
            var url = string.Format("{0}/{1}", Urls.ApplicationFees, applicationFeeId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapFromJson(response);
        }

        [Obsolete( "Use StripeApplicationFeeRefundService.Create instead" )]
        public virtual StripeApplicationFee Refund(string applicationFeeId, int? refundAmount = null)
        {
            var url = string.Format("{0}/{1}/refund", Urls.ApplicationFees, applicationFeeId);
            url = this.ApplyAllParameters(null, url, false);

            if (refundAmount.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeApplicationFee> List(StripeApplicationFeeListOptions listOptions)
        {
            var url = Urls.ApplicationFees;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapCollectionFromJson(response);
        }
    }
}