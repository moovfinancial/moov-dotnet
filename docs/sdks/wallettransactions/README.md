# WalletTransactions

## Overview

### Available Operations

* [List](#list) - List all the transactions associated with a particular Moov wallet. 

Read our [wallet transactions guide](https://docs.moov.io/guides/sources/wallets/transactions/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Get](#get) - Get details on a specific wallet transaction. 

Read our [wallet transactions guide](https://docs.moov.io/guides/sources/wallets/transactions/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

## List

List all the transactions associated with a particular Moov wallet. 

Read our [wallet transactions guide](https://docs.moov.io/guides/sources/wallets/transactions/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listWalletTransactions" method="get" path="/accounts/{accountID}/wallets/{walletID}/transactions" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListWalletTransactionsRequest req = new ListWalletTransactionsRequest() {
    AccountID = "69e4529b-baf0-4f00-877b-123cfd9d6116",
    Skip = 60,
    Count = 20,
    WalletID = "4f971587-62fe-42c9-bc61-7409d9c8660c",
};

var res = await sdk.WalletTransactions.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListWalletTransactionsRequest](../../Models/Requests/ListWalletTransactionsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListWalletTransactionsResponse](../../Models/Requests/ListWalletTransactionsResponse.md)**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| Moov.Sdk.Models.Errors.ListWalletTransactionsValidationError | 422                                                          | application/json                                             |
| Moov.Sdk.Models.Errors.APIException                          | 4XX, 5XX                                                     | \*/\*                                                        |

## Get

Get details on a specific wallet transaction. 

Read our [wallet transactions guide](https://docs.moov.io/guides/sources/wallets/transactions/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWalletTransaction" method="get" path="/accounts/{accountID}/wallets/{walletID}/transactions/{transactionID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.WalletTransactions.GetAsync(
    accountID: "f0b02d73-10dc-42e6-8030-fd78fcbc114f",
    walletID: "03db97f6-c308-4595-8f43-fd247f1bd3f2",
    transactionID: "e0a32cf5-5758-49ba-83da-75bf02c9c6d7"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |
| `WalletID`         | *string*           | :heavy_check_mark: | N/A                |
| `TransactionID`    | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetWalletTransactionResponse](../../Models/Requests/GetWalletTransactionResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |