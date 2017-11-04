// <copyright file="IProxy.cs" company="Rolosoft Ltd">
// Copyright (c) Rolosoft Ltd. All rights reserved.
// </copyright>

// Copyright 2017 Rolosoft Ltd
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
namespace Rsft.Lib.Patterns.Proxy
{
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    /// Proxy pattern.
    /// </summary>
    /// <seealso cref="https://en.wikipedia.org/wiki/Proxy_pattern"/>
    /// <typeparam name="TParams">The type of the parameters.</typeparam>
    /// <typeparam name="TReturn">The type of the return.</typeparam>
    public interface IProxy<in TParams, TReturn>
    {
        /// <summary>
        /// Executes the proxy asynchronously with the specified parameters.
        /// </summary>
        /// <param name="parameters">The parameters (if any).</param>
        /// <param name="cancellationToken">The cancellation token (if any).</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [NotNull]
        [ItemCanBeNull]
        Task<TReturn> ExecuteAsync([CanBeNull] TParams parameters = default(TParams), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Executes the proxy synchronously with the specified parameters.
        /// </summary>
        /// <param name="parameters">The parameters (if any).</param>
        /// <returns>The return type.</returns>
        [CanBeNull]
        TReturn Execute([CanBeNull] TParams parameters = default(TParams));
    }
}