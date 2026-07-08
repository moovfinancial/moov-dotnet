# DepositView

## Overview

### Available Operations

* [Create](#create) - Ingest a deposit account into the deposit view from a core banking source system.

The request body is a raw byte payload whose format depends on the core banking
system that produced it. Set the `X-Source-System` header to identify that system
so the payload can be parsed correctly.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

## Create

Ingest a deposit account into the deposit view from a core banking source system.

The request body is a raw byte payload whose format depends on the core banking
system that produced it. Set the `X-Source-System` header to identify that system
so the payload can be parsed correctly.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createDepositAccount" method="post" path="/underwriting/{accountID}/deposit-accounts" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.DepositView.CreateAsync(
    accountID: "<id>",
    xSourceSystem: SourceSystem.JhCif2020,
    body: System.Text.Encoding.UTF8.GetBytes("0x86dcc65F3b")
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `AccountID`                                                               | *string*                                                                  | :heavy_check_mark:                                                        | N/A                                                                       |
| `XSourceSystem`                                                           | [SourceSystem](../../Models/Components/SourceSystem.md)                   | :heavy_check_mark:                                                        | Identifies the core banking source system that produced the request body. |
| `Body`                                                                    | *byte[]*                                                                  | :heavy_check_mark:                                                        | N/A                                                                       |

### Response

**[CreateDepositAccountResponse](../../Models/Requests/CreateDepositAccountResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                  | 400, 409                                             | application/json                                     |
| Moov.Sdk.Models.Errors.DepositAccountValidationError | 422                                                  | application/json                                     |
| Moov.Sdk.Models.Errors.APIException                  | 4XX, 5XX                                             | \*/\*                                                |