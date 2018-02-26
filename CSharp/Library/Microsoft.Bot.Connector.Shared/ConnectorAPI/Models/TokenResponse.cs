// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A response that includes a user token
    /// </summary>
    public partial class TokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the TokenResponse class.
        /// </summary>
        public TokenResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TokenResponse class.
        /// </summary>
        /// <param name="token">The user token</param>
        /// <param name="expiration">Expiration for the token, in ISO 8601
        /// format (e.g. "2007-04-05T14:30Z")</param>
        public TokenResponse(string token = default(string), string expiration = default(string))
        {
            Token = token;
            Expiration = expiration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the user token
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets expiration for the token, in ISO 8601 format (e.g.
        /// "2007-04-05T14:30Z")
        /// </summary>
        [JsonProperty(PropertyName = "expiration")]
        public string Expiration { get; set; }

    }
}
