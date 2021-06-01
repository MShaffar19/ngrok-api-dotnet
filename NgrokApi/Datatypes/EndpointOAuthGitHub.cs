
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointOAuthGitHub
    {
        // <summary>
        // the OAuth app client ID. retrieve it from the identity provider's dashboard
        // where you created your own OAuth app. optional. if unspecified, ngrok will use
        // its own managed oauth application which has additional restrictions. see the
        // OAuth module docs for more details. if present, client_secret must be present as
        // well.
        // </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        // <summary>
        // the OAuth app client secret. retrieve if from the identity provider's dashboard
        // where you created your own OAuth app. optional, see all of the caveats in the
        // docs for <c>client_id</c>.
        // </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
        // <summary>
        // a list of provider-specific OAuth scopes with the permissions your OAuth app
        // would like to ask for. these may not be set if you are using the ngrok-managed
        // oauth app (i.e. you must pass both <c>client_id</c> and <c>client_secret</c> to
        // set scopes)
        // </summary>
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }
        // <summary>
        // a list of email addresses of users authenticated by identity provider who are
        // allowed access to the endpoint
        // </summary>
        [JsonProperty("email_addresses")]
        public List<string> EmailAddresses { get; set; }
        // <summary>
        // a list of email domains of users authenticated by identity provider who are
        // allowed access to the endpoint
        // </summary>
        [JsonProperty("email_domains")]
        public List<string> EmailDomains { get; set; }
        // <summary>
        // a list of github teams identifiers. users will be allowed access to the endpoint
        // if they are a member of any of these teams. identifiers should be in the 'slug'
        // format qualified with the org name, e.g. <c>org-name/team-name</c>
        // </summary>
        [JsonProperty("teams")]
        public List<string> Teams { get; set; }
        // <summary>
        // a list of github org identifiers. users who are members of any of the listed
        // organizations will be allowed access. identifiers should be the organization's
        // 'slug'
        // </summary>
        [JsonProperty("organizations")]
        public List<string> Organizations { get; set; }

        public override string ToString()
        {
            return $"EndpointOAuthGitHub ClientId={ ClientId }  ClientSecret={ ClientSecret }  Scopes={ Scopes }  EmailAddresses={ EmailAddresses }  EmailDomains={ EmailDomains }  Teams={ Teams }  Organizations={ Organizations } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ClientId?.GetHashCode() ?? 0);

                hash = hash * 23 + (ClientSecret?.GetHashCode() ?? 0);

                hash = hash * 23 + (Scopes?.GetHashCode() ?? 0);

                hash = hash * 23 + (EmailAddresses?.GetHashCode() ?? 0);

                hash = hash * 23 + (EmailDomains?.GetHashCode() ?? 0);

                hash = hash * 23 + (Teams?.GetHashCode() ?? 0);

                hash = hash * 23 + (Organizations?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointOAuthGitHub)obj;
            return (
                 this.ClientId == other.ClientId
                && this.ClientSecret == other.ClientSecret
                && this.Scopes == other.Scopes
                && this.EmailAddresses == other.EmailAddresses
                && this.EmailDomains == other.EmailDomains
                && this.Teams == other.Teams
                && this.Organizations == other.Organizations
            );
        }

    }
}
