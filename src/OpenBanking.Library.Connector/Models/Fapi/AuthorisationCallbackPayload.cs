﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Fapi
{
    public class AuthorisationCallbackPayload
    {
        public AuthorisationCallbackPayload(string idToken, string code, string state, string? nonce)
        {
            IdToken = idToken;
            Code = code;
            State = state;
            Nonce = nonce;
        }


        [JsonProperty("id_token")]
        public string IdToken { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("nonce", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Nonce { get; set; }
    }
}
