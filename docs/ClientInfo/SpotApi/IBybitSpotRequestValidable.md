---
title: IBybitSpotRequestValidable
has_children: false
parent: IBybitClientSpotApi
grand_parent: Rest API documentation
---
*[generated documentation]*  
`BybitClient > SpotApi > IBybitSpotRequestValidable`  
*Base for spot websocket request/response processing*
  
***
*Match response after subscription*  
**bool MatchReponse(JToken responseData);**  
***
*Validate response after subscription*  
**bool ValidateResponse(JToken responseData, ref bool forcedExit);**  
