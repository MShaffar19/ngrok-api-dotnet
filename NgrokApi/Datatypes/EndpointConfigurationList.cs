
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointConfigurationList
    {
        // <summary>
        // the list of all endpoint configurations on this account
        // </summary>
        [JsonProperty("endpoint_configurations")]
        public List<EndpointConfiguration> EndpointConfigurations { get; set; }
        // <summary>
        // URI of the endpoint configurations list API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonProperty("next_page_uri")]
        public string NextPageUri { get; set; }

        public override string ToString()
        {
            return $"EndpointConfigurationList EndpointConfigurations={ EndpointConfigurations }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EndpointConfigurations?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointConfigurationList)obj;
            return (
                 this.EndpointConfigurations == other.EndpointConfigurations
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}