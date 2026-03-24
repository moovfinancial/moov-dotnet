# Adjustments

## Overview

### Available Operations

* [List](#list) - List adjustments associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Get](#get) - Retrieve a specific adjustment associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

## List

List adjustments associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdjustments" method="get" path="/accounts/{accountID}/adjustments" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Adjustments.ListAsync(accountID: "c054f3a6-d542-4310-a955-830739f800f0");

// handle response
```

### Parameters

| Parameter                             | Type                                  | Required                              | Description                           |
| ------------------------------------- | ------------------------------------- | ------------------------------------- | ------------------------------------- |
| `AccountID`                           | *string*                              | :heavy_check_mark:                    | N/A                                   |
| `WalletID`                            | *string*                              | :heavy_minus_sign:                    | A wallet ID to filter adjustments by. |

### Response

**[ListAdjustmentsResponse](../../Models/Requests/ListAdjustmentsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Retrieve a specific adjustment associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdjustment" method="get" path="/accounts/{accountID}/adjustments/{adjustmentID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Adjustments.GetAsync(
    accountID: "3ef4e658-8aaa-449f-a7a4-95a6839172a1",
    adjustmentID: "cbe4a8e7-605f-4667-a308-1afde85cd7a5"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |
| `AdjustmentID`     | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetAdjustmentResponse](../../Models/Requests/GetAdjustmentResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |