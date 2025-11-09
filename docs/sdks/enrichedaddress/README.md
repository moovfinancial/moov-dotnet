# EnrichedAddress
(*EnrichedAddress*)

## Overview

### Available Operations

* [Get](#get) - Fetch enriched address suggestions. Requires a partial address. 
  
To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/profile-enrichment.read` scope.

## Get

Fetch enriched address suggestions. Requires a partial address. 
  
To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/profile-enrichment.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEnrichmentAddress" method="get" path="/enrichment/address" -->
```csharp
using Moov;
using Moov.Models.Requests;

var sdk = new MoovClient(xMoovVersion: "<value>");

GetEnrichmentAddressRequest req = new GetEnrichmentAddressRequest() {
    Search = "<value>",
};

var res = await sdk.EnrichedAddress.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetEnrichmentAddressRequest](../../Models/Requests/GetEnrichmentAddressRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetEnrichmentAddressResponse](../../Models/Requests/GetEnrichmentAddressResponse.md)**

### Errors

| Error Type                      | Status Code                     | Content Type                    |
| ------------------------------- | ------------------------------- | ------------------------------- |
| Moov.Models.Errors.APIException | 4XX, 5XX                        | \*/\*                           |