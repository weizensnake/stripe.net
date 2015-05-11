namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null) : base(apiKey) { }

        public virtual StripeAccount Get()
        {
            var response = Requestor.GetString(Urls.Account, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters( createOptions, Urls.Accounts, false );

            var response = Requestor.PostString( url, ApiKey );

            return Mapper<StripeAccount>.MapFromJson( response );
        }

        public virtual void Delete( string accountId )
        {
            var url = string.Format( "{0}/{1}", Urls.Accounts, accountId );

            Requestor.Delete( url, ApiKey );
        }
    }
}