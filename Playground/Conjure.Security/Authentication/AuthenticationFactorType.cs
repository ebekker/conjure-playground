using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.Security.Authentication
{
    public enum AuthenticationFactorType
    {
        Unknown = 0,

        // Terminology based on:
        //  https://en.wikipedia.org/wiki/Multi-factor_authentication#Authentication_factors

        Knowledge = 1,
        Possession = 2,
        Inherent = 3,

        // TODO:
        //  * Is this truly a distinct classification?
        //  * Couldn't this be a form of Inherent or Possession?
        //    o Inherent - you *ARE* located on network X
        //    o Possession - you *HAVE* access from network X
        Location = 4,
    }
}
