﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using AutoMapper;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Public.PaymentInitiation;
using FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p1.Model;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Converters
{
    public class
        OBWriteDomesticDataInitiationDebtorAccountConverter : ITypeConverter<OBWriteDomesticDataInitiationDebtorAccount,
            OBCashAccountDebtor4>
    {
        public OBCashAccountDebtor4 Convert(OBWriteDomesticDataInitiationDebtorAccount source,
            OBCashAccountDebtor4 destination,
            ResolutionContext context)
        {
            return new OBCashAccountDebtor4(source.SchemeName, source.Identification, source.Name,
                source.SecondaryIdentification);
        }
    }
}