﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FinnovationLabs.OpenBanking.Library.Connector.Persistence
{
    public interface IDbEntityRepository<TEntity> : IDisposable where TEntity : class, IEntity
    {
        ValueTask<TEntity?> GetAsync(string id);

        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);

        Task RemoveAsync(TEntity instance);

        Task AddAsync(TEntity instance);
    }
}
