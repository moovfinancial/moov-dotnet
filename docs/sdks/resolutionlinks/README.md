# ResolutionLinks

## Overview

### Available Operations

* [Create](#create) - Create a resolution link for the specified account. Resolution links are temporary, secure links
sent to merchants to resolve account requirements such as KYC verification or document uploads.  Only one active resolution link
is allowed per connected account. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.write`, `/accounts/{accountID}/representatives.write` and `/accounts/{accountID}/files.write` scopes.
* [List](#list) - List resolution links for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [Get](#get) - Get a resolution link by code.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [Disable](#disable) - Disable a resolution link. Disabled resolution links can no longer be used by merchants.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

## Create

Create a resolution link for the specified account. Resolution links are temporary, secure links
sent to merchants to resolve account requirements such as KYC verification or document uploads.  Only one active resolution link
is allowed per connected account. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.write`, `/accounts/{accountID}/representatives.write` and `/accounts/{accountID}/files.write` scopes.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createResolutionLink" method="post" path="/accounts/{accountID}/resolution-links" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.ResolutionLinks.CreateAsync(
    accountID: "<id>",
    body: new CreateResolutionLink() {
        Recipient = new ResolutionLinkRecipient() {
            Phone = new PhoneNumber() {
                Number = "5555555555",
                CountryCode = "1",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  | Example                                                                      |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `AccountID`                                                                  | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |                                                                              |
| `Body`                                                                       | [CreateResolutionLink](../../Models/Components/CreateResolutionLink.md)      | :heavy_check_mark:                                                           | N/A                                                                          | {<br/>"recipient": {<br/>"phone": {<br/>"number": "5555555555",<br/>"countryCode": "1"<br/>}<br/>}<br/>} |

### Response

**[CreateResolutionLinkResponse](../../Models/Requests/CreateResolutionLinkResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| Moov.Sdk.Models.Errors.GenericError              | 400, 409                                         | application/json                                 |
| Moov.Sdk.Models.Errors.CreateResolutionLinkError | 422                                              | application/json                                 |
| Moov.Sdk.Models.Errors.APIException              | 4XX, 5XX                                         | \*/\*                                            |

## List

List resolution links for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listResolutionLinks" method="get" path="/accounts/{accountID}/resolution-links" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.ResolutionLinks.ListAsync(accountID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[ListResolutionLinksResponse](../../Models/Requests/ListResolutionLinksResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Get a resolution link by code.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getResolutionLink" method="get" path="/accounts/{accountID}/resolution-links/{resolutionLinkCode}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.ResolutionLinks.GetAsync(
    accountID: "<id>",
    resolutionLinkCode: "<value>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `AccountID`          | *string*             | :heavy_check_mark:   | N/A                  |
| `ResolutionLinkCode` | *string*             | :heavy_check_mark:   | N/A                  |

### Response

**[GetResolutionLinkResponse](../../Models/Requests/GetResolutionLinkResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Disable

Disable a resolution link. Disabled resolution links can no longer be used by merchants.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="disableResolutionLink" method="delete" path="/accounts/{accountID}/resolution-links/{resolutionLinkCode}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.ResolutionLinks.DisableAsync(
    accountID: "<id>",
    resolutionLinkCode: "<value>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `AccountID`          | *string*             | :heavy_check_mark:   | N/A                  |
| `ResolutionLinkCode` | *string*             | :heavy_check_mark:   | N/A                  |

### Response

**[DisableResolutionLinkResponse](../../Models/Requests/DisableResolutionLinkResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409                            | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |