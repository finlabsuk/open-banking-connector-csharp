﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Linq;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Public;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Repository
{
    /// Struct corresponding to payload of Open Banking Software Statement type. Fields can be added as required
    public class SoftwareStatementPayload
    {
        private static readonly Dictionary<string, RegistrationScope> SoftwareRoleToApiType =
            new Dictionary<string, RegistrationScope>
            {
                ["AISP"] = RegistrationScope.AccountAndTransaction,
                ["PISP"] = RegistrationScope.PaymentInitiation,
                ["CBPII"] = RegistrationScope.FundsConfirmation
            };

        [JsonProperty("software_on_behalf_of_org")]
        public string SoftwareOnBehalfOfOrg = null!;

        [JsonProperty("software_id")]
        public string SoftwareId { get; set; } = null!;

        [JsonProperty("software_client_id")]
        public string SoftwareClientId { get; set; } = null!;

        [JsonProperty("software_client_name")]
        public string SoftwareClientName { get; set; } = null!;

        [JsonProperty("software_client_description")]
        public string SoftwareClientDescription { get; set; } = null!;

        [JsonProperty("software_version")]
        public float SoftwareVersion { get; set; }

        [JsonProperty("software_client_uri")]
        public string SoftwareClientUri { get; set; } = null!;

        [JsonProperty("software_redirect_uris")]
        public string[] SoftwareRedirectUris { get; set; } = null!;

        [JsonProperty("software_roles")]
        public string[] SoftwareRoles { get; set; } = null!;

        [JsonProperty("org_id")]
        public string OrgId { get; set; } = null!;

        [JsonProperty("org_name")]
        public string OrgName { get; set; } = null!;

        public RegistrationScope RegistrationScope =>
            SoftwareRoles.Select(role => SoftwareRoleToApiType[role]).Aggregate(
                RegistrationScope.None,
                (current, next) => current | next);
    }
}
