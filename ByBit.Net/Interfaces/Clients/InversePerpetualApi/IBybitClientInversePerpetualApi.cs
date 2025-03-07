﻿using CryptoExchange.Net.Interfaces;
using System;

namespace Bybit.Net.Interfaces.Clients.InversePerpetualApi
{
    /// <summary>
    /// Bybit inverse perpetual API endpoints
    /// </summary>
    public interface IBybitClientInversePerpetualApi : IDisposable
    {
        /// <summary>
        /// The factory for creating requests. Used for unit testing
        /// </summary>
        IRequestFactory RequestFactory { get; set; }

        /// <summary>
        /// Endpoints related to account settings, info or actions
        /// </summary>
        IBybitClientInversePerpetualApiAccount Account { get; }

        /// <summary>
        /// Endpoints related to retrieving market and system data
        /// </summary>
        IBybitClientInversePerpetualApiExchangeData ExchangeData { get; }

        /// <summary>
        /// Endpoints related to orders and trades
        /// </summary>
        IBybitClientInversePerpetualApiTrading Trading { get; }
    }
}