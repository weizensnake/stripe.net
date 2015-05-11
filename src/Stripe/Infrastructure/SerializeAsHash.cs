using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe
{
    //used to specify that certain options need to be serialized to the url as a hash
    [AttributeUsage(AttributeTargets.Property)]
    public class SerializeAsHash : Attribute
    {

    }
}
