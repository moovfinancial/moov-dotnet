# Branding

## Overview

### Available Operations

* [Create](#create) - Create brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.write` scope.
* [Upsert](#upsert) - Create or replace brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.write` scope.
* [Get](#get) - Get brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.read` scope.

## Create

Create brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createBrand" method="post" path="/accounts/{accountID}/branding" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Branding.CreateAsync(
    accountID: "0a6ae927-b52b-4ef4-86d0-288f27479817",
    body: new BrandProperties() {
        Colors = new BrandColors() {
            Dark = new BrandColor() {
                Accent = "#111111",
            },
            Light = new BrandColor() {
                Accent = "#111111",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `AccountID`                                                   | *string*                                                      | :heavy_check_mark:                                            | N/A                                                           |
| `Body`                                                        | [BrandProperties](../../Models/Components/BrandProperties.md) | :heavy_check_mark:                                            | N/A                                                           |

### Response

**[CreateBrandResponse](../../Models/Requests/CreateBrandResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError         | 400, 409                                    | application/json                            |
| Moov.Sdk.Models.Errors.BrandValidationError | 422                                         | application/json                            |
| Moov.Sdk.Models.Errors.APIException         | 4XX, 5XX                                    | \*/\*                                       |

## Upsert

Create or replace brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="upsertBrand" method="put" path="/accounts/{accountID}/branding" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Branding.UpsertAsync(
    accountID: "0cd408b1-a57d-477b-825b-12331c2ed00a",
    body: new BrandProperties() {
        Colors = new BrandColors() {
            Dark = new BrandColor() {
                Accent = "#111111",
            },
            Light = new BrandColor() {
                Accent = "#111111",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `AccountID`                                                   | *string*                                                      | :heavy_check_mark:                                            | N/A                                                           |
| `Body`                                                        | [BrandProperties](../../Models/Components/BrandProperties.md) | :heavy_check_mark:                                            | N/A                                                           |

### Response

**[UpsertBrandResponse](../../Models/Requests/UpsertBrandResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError         | 400, 409                                    | application/json                            |
| Moov.Sdk.Models.Errors.BrandValidationError | 422                                         | application/json                            |
| Moov.Sdk.Models.Errors.APIException         | 4XX, 5XX                                    | \*/\*                                       |

## Get

Get brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getBrand" method="get" path="/accounts/{accountID}/branding" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Branding.GetAsync(accountID: "8a4ec43e-d45f-481d-a291-683cb221e3cc");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetBrandResponse](../../Models/Requests/GetBrandResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |