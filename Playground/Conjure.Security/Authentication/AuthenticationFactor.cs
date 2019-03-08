using System;

namespace Conjure.Security.Authentication
{
    public interface IAuthenticationFactor
    {
        string Name { get; }

        AuthenticationFactorType Type { get; }

        bool Authenticate(string instance, string subject, string request);
    }

    public abstract class AuthenticationFactorBase
    {
        public bool Authenticate(object instance, object subject, object request) =>
            throw new System.Security.Authentication.AuthenticationException();
    }

    public class PasswordAuthenticationFactor : AuthenticationFactorBase
    {
        public string Name => "Password";
        public AuthenticationFactorType Type => AuthenticationFactorType.Knowledge;
    }

    public class TOTPdAuthenticationFactor : AuthenticationFactorBase
    {
        public string Name => "TOTP";
        public AuthenticationFactorType Type => AuthenticationFactorType.Possession;
    }

    public class WhitelistAddressAuthenticationFactor : AuthenticationFactorBase
    {
        public string Name => "WhitelistAddress";
        public AuthenticationFactorType Type => AuthenticationFactorType.Location;
    }

    public class ClientCertificateAuthenticationFactor : AuthenticationFactorBase
    {
        public string Name => "ClientCert";
        public AuthenticationFactorType Type => AuthenticationFactorType.Possession;
    }

    public class SQRLAuthenticationFactor : AuthenticationFactorBase
    {
        public string Name => "SQRL";
        public AuthenticationFactorType Type => AuthenticationFactorType.Possession;
    }

    public class OIDCAuthenticationFactor : AuthenticationFactorBase
    {
        public string Name => "SSO-OIDC";
        public AuthenticationFactorType Type => AuthenticationFactorType.Unknown;
    }
}
