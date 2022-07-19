using Bybit.Net.Interfaces.Clients.CopyTradingApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.Net.Clients.CopyTradingApi
{
    public class BybitClientCopyTradingApiTrading : IBybitClientCopyTradingApiTrading
    {
        private BybitClientCopyTradingApi _baseClient;

        internal BybitClientCopyTradingApiTrading(BybitClientCopyTradingApi baseClient)
        {
            _baseClient = baseClient;
        }

    }
}
