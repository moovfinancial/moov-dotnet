# TransferConfig

## Overview

### Available Operations

* [Create](#create) - Create a transfer config for an account.
* [Get](#get) - Get the transfer config for an account.
* [Update](#update) - Update the transfer config for an account.

## Create

Create a transfer config for an account.

### Example Usage: Fixed amount tip config created

<!-- UsageSnippet language="csharp" operationID="createTransferConfig" method="post" path="/accounts/{accountID}/transfer-config" example="Fixed amount tip config created" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TransferConfig.CreateAsync(
    accountID: "<id>",
    body: new CreateTransferConfig() {
        TipPresets = new CreateTipPresets() {
            FixedAmountOptions = new List<AmountDecimal>() {
                new AmountDecimal() {
                    Currency = "USD",
                    ValueDecimal = "12.987654321",
                },
            },
        },
    }
);

// handle response
```
### Example Usage: Percentage tip config created

<!-- UsageSnippet language="csharp" operationID="createTransferConfig" method="post" path="/accounts/{accountID}/transfer-config" example="Percentage tip config created" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TransferConfig.CreateAsync(
    accountID: "<id>",
    body: new CreateTransferConfig() {
        TipPresets = new CreateTipPresets() {
            FixedAmountOptions = new List<AmountDecimal>() {
                new AmountDecimal() {
                    Currency = "USD",
                    ValueDecimal = "12.987654321",
                },
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `AccountID`                                                             | *string*                                                                | :heavy_check_mark:                                                      | Your Moov account ID.                                                   |
| `Body`                                                                  | [CreateTransferConfig](../../Models/Components/CreateTransferConfig.md) | :heavy_check_mark:                                                      | N/A                                                                     |

### Response

**[CreateTransferConfigResponse](../../Models/Requests/CreateTransferConfigResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                  | 400                                                  | application/json                                     |
| Moov.Sdk.Models.Errors.TransferConfigValidationError | 422                                                  | application/json                                     |
| Moov.Sdk.Models.Errors.APIException                  | 4XX, 5XX                                             | \*/\*                                                |

## Get

Get the transfer config for an account.

### Example Usage: Fixed amount tip config

<!-- UsageSnippet language="csharp" operationID="getTransferConfig" method="get" path="/accounts/{accountID}/transfer-config" example="Fixed amount tip config" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TransferConfig.GetAsync(accountID: "<id>");

// handle response
```
### Example Usage: Percentage tip config

<!-- UsageSnippet language="csharp" operationID="getTransferConfig" method="get" path="/accounts/{accountID}/transfer-config" example="Percentage tip config" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TransferConfig.GetAsync(accountID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetTransferConfigResponse](../../Models/Requests/GetTransferConfigResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

Update the transfer config for an account.

### Example Usage: Updated fixed amount tip config

<!-- UsageSnippet language="csharp" operationID="updateTransferConfig" method="put" path="/accounts/{accountID}/transfer-config" example="Updated fixed amount tip config" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TransferConfig.UpdateAsync(
    accountID: "<id>",
    body: new PutTransferConfig() {
        TipPresets = new PutTipPresets() {
            FixedAmountOptions = new List<AmountDecimal>() {
                new AmountDecimal() {
                    Currency = "USD",
                    ValueDecimal = "12.987654321",
                },
            },
        },
    }
);

// handle response
```
### Example Usage: Updated percentage tip config

<!-- UsageSnippet language="csharp" operationID="updateTransferConfig" method="put" path="/accounts/{accountID}/transfer-config" example="Updated percentage tip config" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TransferConfig.UpdateAsync(
    accountID: "<id>",
    body: new PutTransferConfig() {
        TipPresets = new PutTipPresets() {
            FixedAmountOptions = new List<AmountDecimal>() {
                new AmountDecimal() {
                    Currency = "USD",
                    ValueDecimal = "12.987654321",
                },
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AccountID`                                                       | *string*                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `Body`                                                            | [PutTransferConfig](../../Models/Components/PutTransferConfig.md) | :heavy_check_mark:                                                | N/A                                                               |

### Response

**[UpdateTransferConfigResponse](../../Models/Requests/UpdateTransferConfigResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                  | 400                                                  | application/json                                     |
| Moov.Sdk.Models.Errors.TransferConfigValidationError | 422                                                  | application/json                                     |
| Moov.Sdk.Models.Errors.APIException                  | 4XX, 5XX                                             | \*/\*                                                |