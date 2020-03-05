﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using FinnovationLabs.OpenBanking.Library.Connector.Models.Fluent.PaymentInitiation;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Fluent
{
    public interface IOpenBankingRequestBuilder
    {
        SoftwareStatementProfileContext SoftwareStatementProfile();

        BankClientProfileContext BankClientProfile();

        DomesticPaymentConsentContext DomesticPaymentConsent(string openBankingClientProfileId);

        AuthorisationCallbackContext AuthorisationCallback();

        DomesticPaymentContext DomesticPayment(string domesticConsentId);

        ApiProfileContext PaymentInitiationApiProfile();
    }
}