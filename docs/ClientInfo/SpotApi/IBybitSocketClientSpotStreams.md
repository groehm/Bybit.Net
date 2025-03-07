---
title: IBybitSocketClientSpotStreams
has_children: false
parent: Socket API documentation
---
*[generated documentation]*  
`BybitSocketClient > SpotStreams`  
*Bybit spot streams*
  

***

## SubscribeToAccountUpdatesAsync  

[https://bybit-exchange.github.io/docs/spot/v1/#t-privatetopics](https://bybit-exchange.github.io/docs/spot/v1/#t-privatetopics)  
<p>

*Subscribe to account data updates*  

```csharp  
var client = new BybitSocketClient();  
var result = await client.SpotStreams.SubscribeToAccountUpdatesAsync(/* parameters */);  
```  

```csharp  
Task<CallResult<UpdateSubscription>> SubscribeToAccountUpdatesAsync(Action<DataEvent<BybitSpotAccountUpdate>> accountUpdateHandler, Action<DataEvent<BybitSpotOrderUpdate>> orderUpdateHandler, Action<DataEvent<BybitSpotUserTradeUpdate>> tradeUpdateHandler, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|accountUpdateHandler|Account(balance) update handler|
|orderUpdateHandler|Order update handler|
|tradeUpdateHandler|User trade update handler|
|_[Optional]_ ct|Cancellation token for closing this subscription|

</p>

***

## SubscribeToBookPriceUpdatesAsync  

[https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2bookticker](https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2bookticker)  
<p>

*Subscribe to book price updates*  

```csharp  
var client = new BybitSocketClient();  
var result = await client.SpotStreams.SubscribeToBookPriceUpdatesAsync(/* parameters */);  
```  

```csharp  
Task<CallResult<UpdateSubscription>> SubscribeToBookPriceUpdatesAsync(string symbol, Action<DataEvent<BybitSpotBookPrice>> handler, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|handler|Data handler|
|_[Optional]_ ct|Cancellation token for closing this subscription|

</p>

***

## SubscribeToKlineUpdatesAsync  

[https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2kline](https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2kline)  
<p>

*Subscribe to kline updates*  

```csharp  
var client = new BybitSocketClient();  
var result = await client.SpotStreams.SubscribeToKlineUpdatesAsync(/* parameters */);  
```  

```csharp  
Task<CallResult<UpdateSubscription>> SubscribeToKlineUpdatesAsync(string symbol, KlineInterval interval, Action<DataEvent<BybitSpotKlineUpdate>> handler, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|interval|Interval of the kline data|
|handler|Data handler|
|_[Optional]_ ct|Cancellation token for closing this subscription|

</p>

***

## SubscribeToOrderBookUpdatesAsync  

[https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2depth](https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2depth)  
<p>

*Subscribe to order book updates*  

```csharp  
var client = new BybitSocketClient();  
var result = await client.SpotStreams.SubscribeToOrderBookUpdatesAsync(/* parameters */);  
```  

```csharp  
Task<CallResult<UpdateSubscription>> SubscribeToOrderBookUpdatesAsync(string symbol, Action<DataEvent<BybitSpotOrderBookUpdate>> handler, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|handler|Data handler|
|_[Optional]_ ct|Cancellation token for closing this subscription|

</p>

***

## SubscribeToTickerUpdatesAsync  

[https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2realtimes](https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2realtimes)  
<p>

*Subscribe to ticker updates*  

```csharp  
var client = new BybitSocketClient();  
var result = await client.SpotStreams.SubscribeToTickerUpdatesAsync(/* parameters */);  
```  

```csharp  
Task<CallResult<UpdateSubscription>> SubscribeToTickerUpdatesAsync(string symbol, Action<DataEvent<BybitSpotTickerUpdate>> handler, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|handler|Data handler|
|_[Optional]_ ct|Cancellation token for closing this subscription|

</p>

***

## SubscribeToTradeUpdatesAsync  

[https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2trade](https://bybit-exchange.github.io/docs/spot/v1/#t-websocketv2trade)  
<p>

*Subscribe to public trade updates*  

```csharp  
var client = new BybitSocketClient();  
var result = await client.SpotStreams.SubscribeToTradeUpdatesAsync(/* parameters */);  
```  

```csharp  
Task<CallResult<UpdateSubscription>> SubscribeToTradeUpdatesAsync(string symbol, Action<DataEvent<BybitSpotTradeUpdate>> handler, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|handler|Data handler|
|_[Optional]_ ct|Cancellation token for closing this subscription|

</p>
