﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using FinnovationLabs.OpenBanking.Library.Connector.Configuration;
using FinnovationLabs.OpenBanking.Library.Connector.Http;
using FinnovationLabs.OpenBanking.Library.Connector.Instrumentation;
using FinnovationLabs.OpenBanking.Library.Connector.KeySecrets.Providers;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Fluent.PaymentInitiation;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Mapping;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Persistent;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Persistent.PaymentInitiation;
using FinnovationLabs.OpenBanking.Library.Connector.Persistence;
using FinnovationLabs.OpenBanking.Library.Connector.Security;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Fluent
{
    public class RequestBuilder : IOpenBankingRequestBuilder
    {
        private readonly IApiClient _apiClient;
        private readonly IDbEntityRepository<ApiProfile> _apiProfileRepository;
        private readonly ICertificateReader _certificateReader;
        private readonly IDbEntityRepository<BankClientProfile> _clientProfileRepository;
        private readonly IConfigurationProvider _configurationProvider;
        private readonly IDbMultiEntityMethods _dbContextService;
        private readonly IDbEntityRepository<DomesticConsent> _domesticConsentRepo;
        private readonly IEntityMapper _entityMapper;
        private readonly IKeySecretReadOnlyProvider _keySecretReadOnlyProvider;
        private readonly IInstrumentationClient _logger;
        private readonly IDbEntityRepository<SoftwareStatementProfile> _softwareStatementRepo;
        private readonly ITimeProvider _timeProvider;


        public RequestBuilder(
            IEntityMapper entityMapper,
            IDbMultiEntityMethods dbContextService,
            IConfigurationProvider configurationProvider,
            IInstrumentationClient logger,
            IKeySecretReadOnlyProvider keySecretReadOnlyProvider,
            IApiClient apiClient,
            ICertificateReader certificateReader,
            IDbEntityRepository<BankClientProfile> clientProfileRepository,
            IDbEntityRepository<SoftwareStatementProfile> softwareStatementProfileRepo,
            IDbEntityRepository<DomesticConsent> domesticConsentRepo,
            IDbEntityRepository<ApiProfile> apiProfileRepository)
            : this(
                timeProvider: new TimeProvider(),
                entityMapper: entityMapper,
                dbContextService: dbContextService,
                configurationProvider: configurationProvider,
                logger: logger,
                keySecretReadOnlyProvider: keySecretReadOnlyProvider,
                apiClient: apiClient,
                certificateReader: certificateReader,
                clientProfileRepository: clientProfileRepository,
                softwareStatementProfileRepo: softwareStatementProfileRepo,
                domesticConsentRepo: domesticConsentRepo,
                apiProfileRepository: apiProfileRepository) { }

        internal RequestBuilder(
            ITimeProvider timeProvider,
            IEntityMapper entityMapper,
            IDbMultiEntityMethods dbContextService,
            IConfigurationProvider configurationProvider,
            IInstrumentationClient logger,
            IKeySecretReadOnlyProvider keySecretReadOnlyProvider,
            IApiClient apiClient,
            ICertificateReader certificateReader,
            IDbEntityRepository<BankClientProfile> clientProfileRepository,
            IDbEntityRepository<SoftwareStatementProfile> softwareStatementProfileRepo,
            IDbEntityRepository<DomesticConsent> domesticConsentRepo,
            IDbEntityRepository<ApiProfile> apiProfileRepository)
        {
            _certificateReader = certificateReader.ArgNotNull(nameof(certificateReader));
            _timeProvider = timeProvider.ArgNotNull(nameof(timeProvider));
            _entityMapper = entityMapper.ArgNotNull(nameof(entityMapper));
            _dbContextService = dbContextService;
            _configurationProvider = configurationProvider.ArgNotNull(nameof(configurationProvider));
            _logger = logger.ArgNotNull(nameof(logger));
            _keySecretReadOnlyProvider = keySecretReadOnlyProvider.ArgNotNull(nameof(keySecretReadOnlyProvider));
            _apiClient = apiClient.ArgNotNull(nameof(apiClient));
            _clientProfileRepository = clientProfileRepository.ArgNotNull(nameof(clientProfileRepository));
            _softwareStatementRepo = softwareStatementProfileRepo.ArgNotNull(nameof(softwareStatementProfileRepo));
            _domesticConsentRepo = domesticConsentRepo.ArgNotNull(nameof(domesticConsentRepo));
            _apiProfileRepository = apiProfileRepository.ArgNotNull(nameof(apiProfileRepository));
        }

        public SoftwareStatementProfileContext SoftwareStatementProfile()
        {
            ISharedContext context = CreateContext();

            return new SoftwareStatementProfileContext(context);
        }

        public BankClientProfileContext BankClientProfile()
        {
            ISharedContext context = CreateContext();

            return new BankClientProfileContext(context);
        }

        public DomesticPaymentConsentContext DomesticPaymentConsent(string openBankingClientProfileId)
        {
            openBankingClientProfileId.ArgNotNull(nameof(openBankingClientProfileId));

            ISharedContext context = CreateContext();

            return new DomesticPaymentConsentContext(context)
            {
                ApiProfileId = openBankingClientProfileId
            };
        }

        public DomesticPaymentContext DomesticPayment()
        {
            ISharedContext context = CreateContext();
            return new DomesticPaymentContext(context);
        }

        public AuthorisationCallbackDataContext AuthorisationCallbackData()
        {
            ISharedContext context = CreateContext();

            return new AuthorisationCallbackDataContext(context);
        }

        public PaymentInitiationApiProfileContext PaymentInitiationApiProfile()
        {
            ISharedContext context = CreateContext();
            return new PaymentInitiationApiProfileContext(context);
        }

        private ISharedContext CreateContext()
        {
            SharedContext context = new SharedContext(
                certificateReader: _certificateReader,
                apiClient: _apiClient,
                configurationProvider: _configurationProvider,
                instrumentation: _logger,
                keySecretReadOnlyProvider: _keySecretReadOnlyProvider,
                clientProfileRepository: _clientProfileRepository,
                softwareStatementRepository: _softwareStatementRepo,
                domesticConsentRepository: _domesticConsentRepo,
                entityMapper: _entityMapper,
                apiProfileRepository: _apiProfileRepository,
                dbContextService: _dbContextService)
            {
                Created = _timeProvider.GetUtcNow()
            };
            return context;
        }
    }
}
