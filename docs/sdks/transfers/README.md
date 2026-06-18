# Transfers

## Overview

### Available Operations

* [GenerateOptions](#generateoptions) - Generate available payment method options for one or multiple transfer participants depending on the accountID or paymentMethodID you 
supply in the request body.

The accountID in the route should the partner's accountID.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [Create](#create) - Move money by providing the source, destination, and amount in the request body.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [List](#list) - List all the transfers associated with a particular Moov account. 

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more. 

When you run this request, you retrieve 200 transfers at a time. You can advance past a results set of 200 transfers by using the `skip` parameter (for example, 
if you set `skip`= 10, you will see a results set of 200 transfers after the first 10). If you are searching a high volume of transfers, the request will likely 
process very slowly. To achieve faster performance, restrict the data as much as you can by using the `StartDateTime` and `EndDateTime` parameters for a limited 
period of time. You can run multiple requests in smaller time window increments until you've retrieved all the transfers you need.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [BatchGetTransfers](#batchgettransfers) - Retrieve transfer details for multiple transfers in one request. The response is a map from each
requested transfer ID to its full transfer details when available; IDs that are not found or not
accessible under this account are omitted from the map.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Get](#get) - Retrieve full transfer details for an individual transfer of a particular Moov account. 

Payment rail-specific details are included in the source and destination. Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) 
to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Update](#update) - Update the metadata contained on a transfer.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [CreateCancellation](#createcancellation) -   Initiate a cancellation for a card, ACH, or queued transfer.
  
  To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
  to specify the `/accounts/{accountID}/transfers.write` scope.
* [ListCancellations](#listcancellations) -   Get a list of cancellations for a transfer.
  
  To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
  to specify the `/accounts/{accountID}/transfers.read` scope.
* [GetCancellation](#getcancellation) -   Get details of a cancellation for a transfer.
  
  To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
  to specify the `/accounts/{accountID}/transfers.read` scope.
* [InitiateRefund](#initiaterefund) - Initiate a refund for a card transfer.

**Use the [Cancel or refund a card transfer](https://docs.moov.io/api/money-movement/refunds/cancel/) endpoint for more comprehensive cancel and refund options.**    
See the [reversals](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/reversals/) guide for more information. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [ListRefunds](#listrefunds) - Get a list of refunds for a card transfer.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [GetRefund](#getrefund) - Get details of a refund for a card transfer.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [CreateReversal](#createreversal) - Reverses a card transfer by initiating a cancellation or refund depending on the transaction status. 
Read our [reversals guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/reversals/) 
to learn more.

To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts/{accountID}/transfers.write` scope.

## GenerateOptions

Generate available payment method options for one or multiple transfer participants depending on the accountID or paymentMethodID you 
supply in the request body.

The accountID in the route should the partner's accountID.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTransferOptions" method="post" path="/accounts/{accountID}/transfer-options" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.GenerateOptionsAsync(
    accountID: "deafe3cf-31d4-4dcc-8176-3d6bf8bb4f04",
    body: new CreateTransferOptions() {
        Source = new SourceDestinationOptions() {},
        Destination = new SourceDestinationOptions() {},
        Amount = new Amount() {
            Currency = "USD",
            Value = 1204,
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `AccountID`                                                               | *string*                                                                  | :heavy_check_mark:                                                        | The partner's Moov account ID.                                            |
| `Body`                                                                    | [CreateTransferOptions](../../Models/Components/CreateTransferOptions.md) | :heavy_check_mark:                                                        | N/A                                                                       |

### Response

**[CreateTransferOptionsResponse](../../Models/Requests/CreateTransferOptionsResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                   | 400                                                   | application/json                                      |
| Moov.Sdk.Models.Errors.TransferOptionsValidationError | 422                                                   | application/json                                      |
| Moov.Sdk.Models.Errors.APIException                   | 4XX, 5XX                                              | \*/\*                                                 |

## Create

Move money by providing the source, destination, and amount in the request body.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage: Created async transfer

<!-- UsageSnippet language="csharp" operationID="createTransfer" method="post" path="/accounts/{accountID}/transfers" example="Created async transfer" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.CreateAsync(
    xIdempotencyKey: "6de5561f-5a9f-4bd3-a458-ce0baacae20d",
    accountID: "d5696c5b-7106-4093-8a7d-faa71dda002c",
    body: new CreateTransfer() {
        Source = new CreateTransferSource() {
            PaymentMethodID = "9506dbf6-4208-44c3-ad8a-e4431660e1f2",
        },
        Destination = new CreateTransferDestination() {
            PaymentMethodID = "3f9969cf-a1f3-4d83-8ddc-229a506651cf",
        },
        Amount = new Amount() {
            Currency = "USD",
            Value = 32945,
        },
        Description = "Transfer from card to wallet",
        Metadata = new Dictionary<string, string>() {
            { "optional", "metadata" },
        },
        AmountDetails = new CreateTransferAmountDetails() {
            Tip = new AmountDecimal() {
                Currency = "USD",
                ValueDecimal = "3.50",
            },
        },
    }
);

// handle response
```
### Example Usage: Created synchronous transfer

<!-- UsageSnippet language="csharp" operationID="createTransfer" method="post" path="/accounts/{accountID}/transfers" example="Created synchronous transfer" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.CreateAsync(
    xIdempotencyKey: "d6903402-776f-48d6-8fba-0358959d34e5",
    accountID: "ea9f2225-403b-4e2c-93b0-0eda090ffa65",
    body: new CreateTransfer() {
        Source = new CreateTransferSource() {
            PaymentMethodID = "9506dbf6-4208-44c3-ad8a-e4431660e1f2",
        },
        Destination = new CreateTransferDestination() {
            PaymentMethodID = "3f9969cf-a1f3-4d83-8ddc-229a506651cf",
        },
        Amount = new Amount() {
            Currency = "USD",
            Value = 32945,
        },
        Description = "Transfer from card to wallet",
        Metadata = new Dictionary<string, string>() {
            { "optional", "metadata" },
        },
        AmountDetails = new CreateTransferAmountDetails() {
            Tip = new AmountDecimal() {
                Currency = "USD",
                ValueDecimal = "3.50",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                  | Example                                                                                                                                                                                                                                                                                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `XIdempotencyKey`                                                                                                                                                                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                           |   Identifies a unique request to create a transfer.<br/>  In order to avoid creating duplicate transfers, the same idempotency key should be reused when retrying a request.                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                                                                              |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                           | Your Moov account ID.                                                                                                                                                                                                                                                                                                                                                        |                                                                                                                                                                                                                                                                                                                                                                              |
| `Body`                                                                                                                                                                                                                                                                                                                                                                       | [CreateTransfer](../../Models/Components/CreateTransfer.md)                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                                                                                                                                                                          | {<br/>"source": {<br/>"paymentMethodID": "9506dbf6-4208-44c3-ad8a-e4431660e1f2"<br/>},<br/>"destination": {<br/>"paymentMethodID": "3f9969cf-a1f3-4d83-8ddc-229a506651cf"<br/>},<br/>"amount": {<br/>"currency": "USD",<br/>"value": 32945<br/>},<br/>"amountDetails": {<br/>"tip": {<br/>"currency": "USD",<br/>"valueDecimal": "3.50"<br/>}<br/>},<br/>"description": "Transfer from card to wallet",<br/>"metadata": {<br/>"optional": "metadata"<br/>}<br/>} |
| `XWaitFor`                                                                                                                                                                                                                                                                                                                                                                   | [TransferWaitFor](../../Models/Components/TransferWaitFor.md)                                                                                                                                                                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                           | Optional header that indicates whether to return a synchronous response that includes full transfer and rail-specific details or an <br/>asynchronous response indicating the transfer was created (this is the default response if the header is omitted). A timeout will occur after 15 seconds.                                                                           |                                                                                                                                                                                                                                                                                                                                                                              |

### Response

**[CreateTransferResponse](../../Models/Requests/CreateTransferResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError            | 400                                            | application/json                               |
| Moov.Sdk.Models.Errors.TransferException       | 409                                            | application/json                               |
| Moov.Sdk.Models.Errors.TransferValidationError | 422                                            | application/json                               |
| Moov.Sdk.Models.Errors.APIException            | 4XX, 5XX                                       | \*/\*                                          |

## List

List all the transfers associated with a particular Moov account. 

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more. 

When you run this request, you retrieve 200 transfers at a time. You can advance past a results set of 200 transfers by using the `skip` parameter (for example, 
if you set `skip`= 10, you will see a results set of 200 transfers after the first 10). If you are searching a high volume of transfers, the request will likely 
process very slowly. To achieve faster performance, restrict the data as much as you can by using the `StartDateTime` and `EndDateTime` parameters for a limited 
period of time. You can run multiple requests in smaller time window increments until you've retrieved all the transfers you need.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTransfers" method="get" path="/accounts/{accountID}/transfers" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListTransfersRequest req = new ListTransfersRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "0579c895-4d2b-4024-8092-f71b80ab5d00",
};

var res = await sdk.Transfers.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListTransfersRequest](../../Models/Requests/ListTransfersRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListTransfersResponse](../../Models/Requests/ListTransfersResponse.md)**

### Errors

| Error Type                                          | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| Moov.Sdk.Models.Errors.ListTransfersValidationError | 422                                                 | application/json                                    |
| Moov.Sdk.Models.Errors.APIException                 | 4XX, 5XX                                            | \*/\*                                               |

## BatchGetTransfers

Retrieve transfer details for multiple transfers in one request. The response is a map from each
requested transfer ID to its full transfer details when available; IDs that are not found or not
accessible under this account are omitted from the map.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="batchGetTransfers" method="post" path="/accounts/{accountID}/transfers/.fetch" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.BatchGetTransfersAsync(
    accountID: "<id>",
    body: new Moov.Sdk.Models.Components.BatchGetTransfersRequest() {
        TransferIDs = new List<string>() {
            "<value 1>",
            "<value 2>",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                       | *string*                                                                                          | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `Body`                                                                                            | [Models.Components.BatchGetTransfersRequest](../../Models/Components/BatchGetTransfersRequest.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |

### Response

**[BatchGetTransfersResponse](../../Models/Requests/BatchGetTransfersResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Retrieve full transfer details for an individual transfer of a particular Moov account. 

Payment rail-specific details are included in the source and destination. Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) 
to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTransfer" method="get" path="/accounts/{accountID}/transfers/{transferID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.GetAsync(
    transferID: "960cf5a2-50a3-4914-ad86-d54c022bf5df",
    accountID: "31113f7b-9f68-44e9-9338-6d8e655c7c96"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `TransferID`                 | *string*                     | :heavy_check_mark:           | Identifier for the transfer. |
| `AccountID`                  | *string*                     | :heavy_check_mark:           | N/A                          |

### Response

**[GetTransferResponse](../../Models/Requests/GetTransferResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

Update the metadata contained on a transfer.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTransfer" method="patch" path="/accounts/{accountID}/transfers/{transferID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.UpdateAsync(
    transferID: "de30c075-4245-4d62-bfb3-f76d4d7d3b9c",
    accountID: "18a7907d-2f89-493a-b15a-3aad91c24496",
    body: new PatchTransfer() {
        Metadata = new Dictionary<string, string>() {
            { "optional", "metadata" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `TransferID`                                              | *string*                                                  | :heavy_check_mark:                                        | Identifier for the transfer.                              |
| `AccountID`                                               | *string*                                                  | :heavy_check_mark:                                        | N/A                                                       |
| `Body`                                                    | [PatchTransfer](../../Models/Components/PatchTransfer.md) | :heavy_check_mark:                                        | N/A                                                       |

### Response

**[UpdateTransferResponse](../../Models/Requests/UpdateTransferResponse.md)**

### Errors

| Error Type                                          | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| Moov.Sdk.Models.Errors.PatchTransferValidationError | 422                                                 | application/json                                    |
| Moov.Sdk.Models.Errors.APIException                 | 4XX, 5XX                                            | \*/\*                                               |

## CreateCancellation

  Initiate a cancellation for a card, ACH, or queued transfer.
  
  To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
  to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCancellation" method="post" path="/accounts/{accountID}/transfers/{transferID}/cancellations" example="Created cancellation" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.CreateCancellationAsync(
    accountID: "10ae862c-6658-4f87-967d-46e995737204",
    transferID: "36c80a6c-ceb2-4e5d-a437-8a39afdfdc58"
);

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `AccountID`                    | *string*                       | :heavy_check_mark:             | The partner's Moov account ID. |
| `TransferID`                   | *string*                       | :heavy_check_mark:             | The transfer ID to cancel.     |

### Response

**[CreateCancellationResponse](../../Models/Requests/CreateCancellationResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400                                 | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ListCancellations

  Get a list of cancellations for a transfer.
  
  To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
  to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCancellations" method="get" path="/accounts/{accountID}/transfers/{transferID}/cancellations" example="Cancellations" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.ListCancellationsAsync(
    accountID: "<id>",
    transferID: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AccountID`                                                         | *string*                                                            | :heavy_check_mark:                                                  | Moov account ID of the partner or transfer's source or destination. |
| `TransferID`                                                        | *string*                                                            | :heavy_check_mark:                                                  | Identifier for the transfer.                                        |

### Response

**[ListCancellationsResponse](../../Models/Requests/ListCancellationsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetCancellation

  Get details of a cancellation for a transfer.
  
  To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
  to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCancellation" method="get" path="/accounts/{accountID}/transfers/{transferID}/cancellations/{cancellationID}" example="Cancellation" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.GetCancellationAsync(
    accountID: "55cb62c2-22e4-4a36-bd53-3b9adc77ee81",
    transferID: "bc13b680-bac3-432e-bf44-e9aa6426cbb2",
    cancellationID: "770cb4b5-d5b0-4e8b-995b-86b790296ba5"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AccountID`                                                         | *string*                                                            | :heavy_check_mark:                                                  | Moov account ID of the partner or transfer's source or destination. |
| `TransferID`                                                        | *string*                                                            | :heavy_check_mark:                                                  | Identifier for the transfer.                                        |
| `CancellationID`                                                    | *string*                                                            | :heavy_check_mark:                                                  | Identifier for the cancellation.                                    |

### Response

**[GetCancellationResponse](../../Models/Requests/GetCancellationResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## InitiateRefund

Initiate a refund for a card transfer.

**Use the [Cancel or refund a card transfer](https://docs.moov.io/api/money-movement/refunds/cancel/) endpoint for more comprehensive cancel and refund options.**    
See the [reversals](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/reversals/) guide for more information. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage: Successful async refund

<!-- UsageSnippet language="csharp" operationID="initiateRefund" method="post" path="/accounts/{accountID}/transfers/{transferID}/refunds" example="Successful async refund" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

InitiateRefundRequest req = new InitiateRefundRequest() {
    XIdempotencyKey = "8d9af6b8-67e1-4efa-8188-68039f34097d",
    AccountID = "cb6ae9f9-afab-4f06-9eb0-8abf54a3ada2",
    TransferID = "04022119-95be-4ef4-9dd4-b3782f6aa7b9",
    Body = new CreateRefund() {
        Amount = 1000,
    },
};

var res = await sdk.Transfers.InitiateRefundAsync(req);

// handle response
```
### Example Usage: Successful sync refund

<!-- UsageSnippet language="csharp" operationID="initiateRefund" method="post" path="/accounts/{accountID}/transfers/{transferID}/refunds" example="Successful sync refund" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

InitiateRefundRequest req = new InitiateRefundRequest() {
    XIdempotencyKey = "4e7a906a-e6d1-4bca-9cc5-6246295ef93c",
    AccountID = "d12ddb6e-0ed9-44e8-92a7-1716ae7cc759",
    TransferID = "d73be489-9da4-4be7-bc04-147d8552279d",
    Body = new CreateRefund() {
        Amount = 1000,
    },
};

var res = await sdk.Transfers.InitiateRefundAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [InitiateRefundRequest](../../Models/Requests/InitiateRefundRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[InitiateRefundResponse](../../Models/Requests/InitiateRefundResponse.md)**

### Errors

| Error Type                                          | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                 | 400                                                 | application/json                                    |
| Moov.Sdk.Models.Errors.CardAcquiringRefundException | 409                                                 | application/json                                    |
| Moov.Sdk.Models.Errors.RefundValidationError        | 422                                                 | application/json                                    |
| Moov.Sdk.Models.Errors.APIException                 | 4XX, 5XX                                            | \*/\*                                               |

## ListRefunds

Get a list of refunds for a card transfer.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRefunds" method="get" path="/accounts/{accountID}/transfers/{transferID}/refunds" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.ListRefundsAsync(
    accountID: "03f5baaa-f5d8-44bd-90db-868745fe66e8",
    transferID: "6b1aa1a1-bff1-43b9-9126-2806fdc9c732"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `AccountID`                  | *string*                     | :heavy_check_mark:           | N/A                          |
| `TransferID`                 | *string*                     | :heavy_check_mark:           | Identifier for the transfer. |

### Response

**[ListRefundsResponse](../../Models/Requests/ListRefundsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetRefund

Get details of a refund for a card transfer.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRefund" method="get" path="/accounts/{accountID}/transfers/{transferID}/refunds/{refundID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.GetRefundAsync(
    transferID: "e90d3386-c5b2-4e2b-b841-efc590eba6c0",
    accountID: "bbb69538-edaa-4a0b-b107-f46f2da89864",
    refundID: "8e12687e-a4e8-46c9-9e11-a57bbd781e44"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `TransferID`                 | *string*                     | :heavy_check_mark:           | Identifier for the transfer. |
| `AccountID`                  | *string*                     | :heavy_check_mark:           | N/A                          |
| `RefundID`                   | *string*                     | :heavy_check_mark:           | Identifier for the refund.   |

### Response

**[GetRefundResponse](../../Models/Requests/GetRefundResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## CreateReversal

Reverses a card transfer by initiating a cancellation or refund depending on the transaction status. 
Read our [reversals guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/reversals/) 
to learn more.

To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage: Reversed by cancellation

<!-- UsageSnippet language="csharp" operationID="createReversal" method="post" path="/accounts/{accountID}/transfers/{transferID}/reversals" example="Reversed by cancellation" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.CreateReversalAsync(
    xIdempotencyKey: "93d03831-45c4-49ec-a9b2-88cbd41dfca7",
    accountID: "c5fade57-7e5a-4380-ac7b-4abf8b3c24cf",
    transferID: "82c6eae7-b7e5-4b20-b24e-5116a4d70bde",
    body: new CreateReversal() {
        Amount = 1000,
    }
);

// handle response
```
### Example Usage: Reversed by refund

<!-- UsageSnippet language="csharp" operationID="createReversal" method="post" path="/accounts/{accountID}/transfers/{transferID}/reversals" example="Reversed by refund" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Transfers.CreateReversalAsync(
    xIdempotencyKey: "b91d00b2-4ecb-4eb4-a67f-d6f76c0b7ad8",
    accountID: "f225b49d-911b-440b-baed-6065968b69cb",
    transferID: "a17b29e2-4af6-4c9d-ad3a-dd0ded2966ad",
    body: new CreateReversal() {
        Amount = 1000,
    }
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `XIdempotencyKey`                                           | *string*                                                    | :heavy_check_mark:                                          | Prevents duplicate reversals from being created.            |
| `AccountID`                                                 | *string*                                                    | :heavy_check_mark:                                          | The Moov account ID.                                        |
| `TransferID`                                                | *string*                                                    | :heavy_check_mark:                                          | The transfer ID to reverse.                                 |
| `Body`                                                      | [CreateReversal](../../Models/Components/CreateReversal.md) | :heavy_minus_sign:                                          | N/A                                                         |

### Response

**[CreateReversalResponse](../../Models/Requests/CreateReversalResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError            | 400, 409                                       | application/json                               |
| Moov.Sdk.Models.Errors.ReversalValidationError | 422                                            | application/json                               |
| Moov.Sdk.Models.Errors.APIException            | 4XX, 5XX                                       | \*/\*                                          |