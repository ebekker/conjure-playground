using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conjure.Security.Authentication
{
    public class AuthenticationProfile
    {
        public string Name { get; }
    }

    public class AuthenticationProfileFactor
    {
        public AuthenticationProfile Profile { get; }

        public IAuthenticationFactor Factor { get; }

        public AuthenticationFactorRequirement Requirement { get; }

        public int RelativeOrder { get; }

        public string FactorState { get; }
    }

    public class SubjectAuthentication
    {
        public Subject Subject { get; }

        public SubjectAuthentication Parent { get; }

        public AuthenticationProfile Profile { get; }

        public AuthenticationProfile EffectiveProfile => Profile ?? Parent?.EffectiveProfile;
    }

    public class SubjectAuthenticationFactor
    {
        public string FactorState { get; }
    }

    public class Authenticator
    {
        public static IEnumerable<AuthenticationProfileFactor> GetAuthenticationProfileFactors(
            AuthenticationProfile profile) => null;

        public static SubjectAuthenticationFactor GetSubjectAuthenticationFactor(Subject subject,
            IAuthenticationFactor factor) => null;

        public static bool Authenticate(SubjectAuthentication sa, string request)
        {
            bool? optionalAuth = default; // This will default to the first Optional factor below
            bool? requiredAuth = default; // This will default to the first Required factor below

            foreach (var af in GetAuthenticationProfileFactors(sa.EffectiveProfile).OrderBy(x => x.RelativeOrder))
            {
                var auth = af.Factor.Authenticate(
                    af.FactorState,
                    GetSubjectAuthenticationFactor(sa.Subject, af.Factor)?.FactorState,
                    request);
                switch (af.Requirement)
                {
                    case AuthenticationFactorRequirement.Optional:
                        // Any optional factor that succeeds or default to result of first
                        optionalAuth = auth || (optionalAuth??auth);
                        break;

                    case AuthenticationFactorRequirement.Required:
                        // All required factors must succeed, and default to the result of first
                        requiredAuth = (requiredAuth??auth) && auth;
                        break;

                    case AuthenticationFactorRequirement.Requisite:
                        if (!auth)
                            return false;
                        break;

                    case AuthenticationFactorRequirement.Sufficient:
                        if (auth)
                            return true;
                        break;
                }
            }

            // Either all required succeeded,
            // or if there were none, any optional succeed,
            // or if there were none, FAIL
            return requiredAuth ?? optionalAuth ?? false;
        }
    }
}
