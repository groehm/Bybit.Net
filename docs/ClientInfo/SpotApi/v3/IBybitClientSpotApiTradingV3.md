---
title: IBybitClientSpotApiTradingV3
has_children: false
parent: IBybitClientSpotApi\v3
grand_parent: Rest API documentation
---
*[generated documentation]*  
`BybitClient > SpotApi\v3 > SpotApiTradingV3`  
*Bybit trading endpoints, placing and managing orders.*
  

***

## CancelMultipleOrderAsync  

<p>

*Cancel multiple orders based on the provided parameters*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.CancelMultipleOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult> CancelMultipleOrderAsync(string symbol, OrderSide? side = default, IEnumerable<OrderType>? orderTypes = default, int? orderCategory, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol to cancel orders on|
|_[Optional]_ side|Only cancel buy or sell orders|
|_[Optional]_ orderTypes|Only cancel orders fitting the order types, default only cancels Limit orders (not LimitMaker orders)|
|orderCategory| Order category. 0：normal order by default; 1：TP/SL order, Required for TP/SL order. |
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## CancelOrderAsync  

[https://bybit-exchange.github.io/docs/spot/#t-cancelactive](https://bybit-exchange.github.io/docs/spot/#t-cancelactive)  
<p>

*Cancel an active order. Either orderId or clientOrderId should be provided*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.CancelOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitSpotOrderPlaced>> CancelOrderAsync(long? orderId = default, string? clientOrderId = default, int? orderCategory, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ orderId|The order id|
|_[Optional]_ clientOrderId|The client order id|
|orderCategory| Order category. 0：normal order by default; 1：TP/SL order, Required for TP/SL order. |
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetBorrowRecordsAsync  

[https://bybit-exchange.github.io/docs/spot/#t-queryborrowinginfo](https://bybit-exchange.github.io/docs/spot/#t-queryborrowinginfo)  
<p>

*Get borrow records*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.GetBorrowRecordsAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitBorrowRecord>>> GetBorrowRecordsAsync(DateTime? startTime = default, DateTime? endTime = default, string? asset = default, BorrowStatus? status = default, int? limit = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ startTime|Filter by borrow time|
|_[Optional]_ endTime|Filter by borrow time|
|_[Optional]_ asset|Filter by asset|
|_[Optional]_ status|Filter by status|
|_[Optional]_ limit|Max amount of results|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOpenOrdersAsync  

[https://bybit-exchange.github.io/docs/spot/#t-openorders](https://bybit-exchange.github.io/docs/spot/#t-openorders)  
<p>

*Get open orders*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.GetOpenOrdersAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitSpotOrderWrapper>> GetOpenOrdersAsync(string? symbol = default, long? orderId = default, int? limit = default, int? orderCategory, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ symbol|The symbol|
|_[Optional]_ orderId|Filter by order id, will only return orders with an orderId smaller than this|
|_[Optional]_ limit|Max amount of results|
|orderCategory|Order category. 0：normal order by default; 1：TP/SL order, Required for TP/SL order.|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOrderAsync  

[https://bybit-exchange.github.io/docs/spot/#t-getactive](https://bybit-exchange.github.io/docs/spot/#t-getactive)  
<p>

*Get order, either orderId or clientOrderId should be provided*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.GetOrderAsync();  
```  

```csharp  
Task<WebCallResult<BybitSpotOrderV3>> GetOrderAsync(long? orderId = default, string? clientOrderId = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ orderId|The id of the order|
|_[Optional]_ clientOrderId|The client order id|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOrdersAsync  

[https://bybit-exchange.github.io/docs/spot/#t-orderhistory](https://bybit-exchange.github.io/docs/spot/#t-orderhistory)  
<p>

*Get orders*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.GetOrdersAsync();  
```  

```csharp  
Task<WebCallResult<BybitSpotOrderWrapper>> GetOrdersAsync(string? symbol = default, long? orderId = default, int? limit = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ symbol|Filter by symbol|
|_[Optional]_ orderId|Filter by order id, will only return orders with an orderId smaller than this|
|_[Optional]_ limit|Max amount of results|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetRepayRecordsAsync  

[https://bybit-exchange.github.io/docs/spot/#t-queryrepaymenthistory](https://bybit-exchange.github.io/docs/spot/#t-queryrepaymenthistory)  
<p>

*Get repayment records*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.GetRepayRecordsAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitRepayRecord>>> GetRepayRecordsAsync(DateTime? startTime = default, DateTime? endTime = default, string? asset = default, int? limit = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ startTime|Filter by borrow time|
|_[Optional]_ endTime|Filter by borrow time|
|_[Optional]_ asset|Filter by asset|
|_[Optional]_ limit|Max amount of results|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetUserTradesAsync  

[https://bybit-exchange.github.io/docs/spot/#t-tradehistory](https://bybit-exchange.github.io/docs/spot/#t-tradehistory)  
<p>

*Get user trade history*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.GetUserTradesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitSpotUserTrade>>> GetUserTradesAsync(string? symbol = default, long? fromId = default, long? toId = default, int? limit = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ symbol|Filter by symbol|
|_[Optional]_ fromId|Filter by start id|
|_[Optional]_ toId|Filter by end id|
|_[Optional]_ limit|Max amount of results|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## PlaceBorrowOrderAsync  

[https://bybit-exchange.github.io/docs/spot/#t-borrowmarginloan](https://bybit-exchange.github.io/docs/spot/#t-borrowmarginloan)  
<p>

*Place a new borrow order*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.PlaceBorrowOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<long>> PlaceBorrowOrderAsync(string asset, decimal quantity, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|asset|The asset to borrow|
|quantity|The quantity to borrow|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## PlaceOrderAsync  

[https://bybit-exchange.github.io/docs/spot/v3/#t-placeactive](https://bybit-exchange.github.io/docs/spot/v3/#t-placeactive)  
<p>

*Place a new order*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.PlaceOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitSpotOrderPlaced>> PlaceOrderAsync(string symbol, OrderSide side, OrderType type, decimal quantity, decimal? price = default, TimeInForce? timeInForce = default, string? clientOrderId = default, int orderCategory, decimal? triggerPrice = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|side|Order side|
|type|Order type|
|quantity|Quantity of the order. Note that for market buy orders this is the quantity of quote asset, otherwise it's in base asset|
|_[Optional]_ price|Price|
|_[Optional]_ timeInForce|Time in force|
|_[Optional]_ clientOrderId|Client order id|
|orderCategory| Order category. 0：normal order; 1：TP/SL order |
|_[Optional]_ triggerPrice| Trigger price |
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## PlaceRepayOrderAsync  

[https://bybit-exchange.github.io/docs/spot/#t-repaymarginloan](https://bybit-exchange.github.io/docs/spot/#t-repaymarginloan)  
<p>

*Place a new borrow order*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi\v3.SpotApiTradingV3.PlaceRepayOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<long>> PlaceRepayOrderAsync(string asset, decimal quantity, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|asset|The asset to repay|
|quantity|The quantity to repay|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>
