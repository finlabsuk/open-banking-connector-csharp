﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading.Tasks;

namespace FinnovationLabs.OpenBanking.Library.Connector.KeySecrets.Repositories
{
    public interface IKeySecretMultiItemRepository<TItem> : IKeySecretMultiItemReadOnlyRepository<TItem>
        where TItem : class, IKeySecretItemWithId<TItem>
    {
        Task UpsertAsync(TItem instance);
    }
}
