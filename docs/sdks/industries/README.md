# Industries

## Overview

### Available Operations

* [List](#list) - Returns a list of industries relevant to merchant profile enrichment.  Results are ordered by industry name.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/),
you'll need to specify the `/profile-enrichment.read` scope.

## List

Returns a list of industries relevant to merchant profile enrichment.  Results are ordered by industry name.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/),
you'll need to specify the `/profile-enrichment.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listIndustries" method="get" path="/industries" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Industries.ListAsync();

// handle response
```

### Response

**[ListIndustriesResponse](../../Models/Requests/ListIndustriesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |