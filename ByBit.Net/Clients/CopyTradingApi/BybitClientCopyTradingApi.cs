﻿using Bybit.Net.Interfaces.Clients.CopyTradingApi;
using Bybit.Net.Objects;
using Bybit.Net.Objects.Internal;
using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Bybit.Net.Clients.CopyTradingApi
{
    /// <inheritdoc cref="IBybitClientCopyTradingApi" />
    public class BybitClientCopyTradingApi : RestApiClient, IBybitClientCopyTradingApi
    {
        internal static TimeSyncState TimeSyncState = new TimeSyncState("CopyTrade Api");

        internal BybitClientOptions ClientOptions { get; }

        /// <inheritdoc />
        public string ExchangeName => "Bybit";

        /// <inheritdoc />
        public IBybitClientCopyTradingApiAccount Account { get; }
        /// <inheritdoc />
        public IBybitClientCopyTradingApiExchangeData ExchangeData { get; }
        /// <inheritdoc />
        public IBybitClientCopyTradingApiTrading Trading { get; }

        #region ctor
        internal BybitClientCopyTradingApi(Log log, BybitClientOptions options)
            : base(log, options, options.CopyTradingApiOptions)
        {
            if (!string.IsNullOrEmpty(options.Referer))
            {
                StandardRequestHeaders = new Dictionary<string, string>
                {
                    { "x-referer", options.Referer! }
                };
            }

            _log = log;
            ClientOptions = options;

            Account = new BybitClientCopyTradingApiAccount(this);
            ExchangeData = new BybitClientCopyTradingApiExchangeData(this);
            Trading = new BybitClientCopyTradingApiTrading(this);

            requestBodyFormat = RequestBodyFormat.FormData;
            ParameterPositions[HttpMethod.Delete] = HttpMethodParameterPosition.InUri;
        }
        #endregion

        /// <inheritdoc />
        protected override AuthenticationProvider CreateAuthenticationProvider(ApiCredentials credentials)
            => new BybitAuthenticationProvider(credentials);

        /// <summary>
        /// Get url for an endpoint
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        internal Uri GetUrl(string endpoint)
        {
            return new Uri(BaseAddress.AppendPath(endpoint));
        }

        internal async Task<WebCallResult<BybitResult<T>>> SendRequestWrapperAsync<T>(
             Uri uri,
             HttpMethod method,
             CancellationToken cancellationToken,
             Dictionary<string, object>? parameters = null,
             bool signed = false,
             JsonSerializer? deserializer = null) where T : class
        {
            var result = await base.SendRequestAsync<BybitResult<T>>(uri, method, cancellationToken, parameters, signed, deserializer: deserializer).ConfigureAwait(false);
            if (!result)
                return result.As<BybitResult<T>>(default);

            if (result.Data.ReturnCode != 0)
                return result.AsError<BybitResult<T>>(new ServerError(result.Data.ReturnCode, result.Data.ReturnMessage));               

            return result.As(result.Data);
        }

        internal async Task<WebCallResult<IEnumerable<T>>> SendRequestListAsync<T>(
             Uri uri,
             HttpMethod method,
             CancellationToken cancellationToken,
             Dictionary<string, object>? parameters = null,
             bool signed = false,
             JsonSerializer? deserializer = null,
             bool ignoreRatelimit = false)
        {
            var result = await base.SendRequestAsync<BybitCopyTradingResult<BybitList<T>>>(uri, method, cancellationToken, parameters, signed, deserializer: deserializer, ignoreRatelimit: ignoreRatelimit).ConfigureAwait(false);
            if (!result)
                return result.As<IEnumerable<T>>(default);

            if (result.Data.ReturnCode != 0)
                return result.AsError<IEnumerable<T>>(new ServerError(result.Data.ReturnCode, result.Data.ReturnMessage));

            return result.As(result.Data.Result.List);
        }

        internal async Task<WebCallResult<T>> SendRequestAsync<T>(
             Uri uri,
             HttpMethod method,
             CancellationToken cancellationToken,
             Dictionary<string, object>? parameters = null,
             bool signed = false,
             JsonSerializer? deserializer = null,
             bool ignoreRatelimit = false)
        {
            var result = await base.SendRequestAsync<BybitCopyTradingResult<T>>(uri, method, cancellationToken, parameters, signed, deserializer: deserializer, ignoreRatelimit: ignoreRatelimit).ConfigureAwait(false);
            if (!result)
                return result.As<T>(default);

            if (result.Data.ReturnCode != 0)
                return result.AsError<T>(new ServerError(result.Data.ReturnCode, result.Data.ReturnMessage));
                
            return result.As(result.Data.Result);
        }

        /// <inheritdoc />
        protected override Task<WebCallResult<DateTime>> GetServerTimestampAsync()
            => ExchangeData.GetServerTimeAsync();

        /// <inheritdoc />
        public override TimeSyncInfo GetTimeSyncInfo()
            => new TimeSyncInfo(_log, Options.AutoTimestamp,Options.TimestampRecalculationInterval, TimeSyncState);

        /// <inheritdoc />
        public override TimeSpan GetTimeOffset()
            => TimeSyncState.TimeOffset;
    }
}
