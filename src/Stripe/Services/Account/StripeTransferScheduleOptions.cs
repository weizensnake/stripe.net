using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferScheduleOptions
    {
        [JsonProperty( "delay_days" )]
        public int? DelayDays { get; set; }

        [JsonProperty( "interval" )]
        public string Interval { get; set; }

        [JsonProperty( "monthly_anchor" )]
        public int? MonthlyAnchor { get; set; }

        [JsonProperty( "weekly_anchor" )]
        public string WeeklyAnchor { get; set; }

        [JsonProperty( "metadata" )]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
