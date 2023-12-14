// <auto-generated /> (Turns off StyleCop analysis in this file.)
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Extensions.Configuration.EnvironmentVariables
{
    /// <summary>
    /// An environment variable based <see cref="ConfigurationProvider"/>.
    /// </summary>
    internal sealed class EnvironmentVariablesConfigurationProvider : ConfigurationProvider
    {
        private readonly string _prefix;
        private readonly string _normalizedPrefix;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public EnvironmentVariablesConfigurationProvider()
        {
            _prefix = string.Empty;
            _normalizedPrefix = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance with the specified prefix.
        /// </summary>
        /// <param name="prefix">A prefix used to filter the environment variables.</param>
        public EnvironmentVariablesConfigurationProvider(string? prefix)
        {
            _prefix = prefix ?? string.Empty;
            _normalizedPrefix = Normalize(_prefix);
        }

        /// <summary>
        /// Loads the environment variables.
        /// </summary>
        public override void Load() =>
            Load(Environment.GetEnvironmentVariables());

        /// <summary>
        /// Generates a string representing this provider name and relevant details.
        /// </summary>
        /// <returns> The configuration name. </returns>
        public override string ToString()
            => $"{GetType().Name} Prefix: '{_prefix}'";

        internal void Load(IDictionary envVariables)
        {
            var data = new Dictionary<string, string?>(StringComparer.OrdinalIgnoreCase);

            IDictionaryEnumerator e = envVariables.GetEnumerator();
            try
            {
                while (e.MoveNext())
                {
                    string key = (string)e.Entry.Key;
                    string? value = (string?)e.Entry.Value;
                    AddIfNormalizedKeyMatchesPrefix(data, Normalize(key), value);
                }
            }
            finally
            {
                (e as IDisposable)?.Dispose();
            }

            Data = data;
        }

        private void AddIfNormalizedKeyMatchesPrefix(Dictionary<string, string?> data, string normalizedKey, string? value)
        {
            if (normalizedKey.StartsWith(_normalizedPrefix, StringComparison.OrdinalIgnoreCase))
            {
                data[normalizedKey.Substring(_normalizedPrefix.Length)] = value;
            }
        }

        private static string Normalize(string key) => key.Replace("__", ConfigurationPath.KeyDelimiter);
    }
}
