using System;
using System.Collections.Generic;
using System.Text;

namespace Conjure.Security.Authentication
{
    // Ideas based on PAM control flags:
    //  https://ldapwiki.com/wiki/PAM%20Control

    public enum AuthenticationFactorRequirement
    {
        Required = 0,
        Requisite = 1,
        Sufficient = 2,
        Optional = 3,
    }
}
