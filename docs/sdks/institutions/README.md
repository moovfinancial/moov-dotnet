# Institutions

## Overview

### Available Operations

* [SearchInstitutions](#searchinstitutions) - Search for financial institutions by name or routing number.

This endpoint returns metadata about each matched institution, including basic identifying details (such as name, routing number, and address) and information about which payment services they support (e.g., ACH, RTP, and Wire).

This can be used to validate a financial institution before initiating payment activity, or to check which payment rails are available for a given routing number.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/institutions.read` scope.
* [~~Search~~](#search) - This endpoint has been deprecated and will be removed in a future release. Use [/institutions](https://docs.moov.io/api/enrichment/form-shortening/institutions/get/).

Search for institutions by either their name or routing number.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/fed.read` scope. :warning: **Deprecated**

## SearchInstitutions

Search for financial institutions by name or routing number.

This endpoint returns metadata about each matched institution, including basic identifying details (such as name, routing number, and address) and information about which payment services they support (e.g., ACH, RTP, and Wire).

This can be used to validate a financial institution before initiating payment activity, or to check which payment rails are available for a given routing number.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/institutions.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="searchInstitutions" method="get" path="/institutions" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Institutions.SearchInstitutionsAsync();

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Name`                                                                                    | *string*                                                                                  | :heavy_minus_sign:                                                                        | Name of the financial institution. Either `name` or `routingNumber` is required.          |
| `RoutingNumber`                                                                           | *string*                                                                                  | :heavy_minus_sign:                                                                        | Routing number for a financial institution. Either `routingNumber` or `name` is required. |
| `Limit`                                                                                   | *long*                                                                                    | :heavy_minus_sign:                                                                        | Maximum results returned by a search.                                                     |

### Response

**[SearchInstitutionsResponse](../../Models/Requests/SearchInstitutionsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ~~Search~~

This endpoint has been deprecated and will be removed in a future release. Use [/institutions](https://docs.moov.io/api/enrichment/form-shortening/institutions/get/).

Search for institutions by either their name or routing number.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/fed.read` scope.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listInstitutions" method="get" path="/institutions/ach/search" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Institutions.SearchAsync();

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Name`                                                                                    | *string*                                                                                  | :heavy_minus_sign:                                                                        | Name of the financial institution. Either `name` or `routingNumber` is required.          |
| `RoutingNumber`                                                                           | *string*                                                                                  | :heavy_minus_sign:                                                                        | Routing number for a financial institution. Either `routingNumber` or `name` is required. |
| `State`                                                                                   | *string*                                                                                  | :heavy_minus_sign:                                                                        | The state where a financial institution is based.                                         |
| `Limit`                                                                                   | *long*                                                                                    | :heavy_minus_sign:                                                                        | Maximum results returned by a search.                                                     |

### Response

**[ListInstitutionsResponse](../../Models/Requests/ListInstitutionsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400                                 | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |