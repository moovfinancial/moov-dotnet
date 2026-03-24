# Wallets

## Overview

### Available Operations

* [Create](#create) - Create a new wallet for an account. You can specify optional attributes such as a display name and description to specify the intended use of the wallet. This will generate a new moov-wallet payment method.

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.write` scope.
* [List](#list) - List the wallets associated with a Moov account. 

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Get](#get) - Get information on a specific wallet (e.g., the available balance). 

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Update](#update) - Update properties of an existing wallet such as name, description, status, or metadata.

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/wallets.write` scope.

## Create

Create a new wallet for an account. You can specify optional attributes such as a display name and description to specify the intended use of the wallet. This will generate a new moov-wallet payment method.

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createWallet" method="post" path="/accounts/{accountID}/wallets" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Wallets.CreateAsync(
    accountID: "b4b3f37c-b73e-4271-b8ec-108a8593c9b9",
    body: new CreateWallet() {
        Name = "My wallet",
        Description = "A general wallet used for my payments",
        Metadata = new Dictionary<string, string>() {
            { "optional", "metadata" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             | Example                                                                                                                 |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                             | *string*                                                                                                                | :heavy_check_mark:                                                                                                      | The Moov account ID the wallet belongs to.                                                                              |                                                                                                                         |
| `Body`                                                                                                                  | [CreateWallet](../../Models/Components/CreateWallet.md)                                                                 | :heavy_check_mark:                                                                                                      | N/A                                                                                                                     | {<br/>"name": "My wallet",<br/>"description": "A general wallet used for my payments",<br/>"metadata": {<br/>"optional": "metadata"<br/>}<br/>} |

### Response

**[CreateWalletResponse](../../Models/Requests/CreateWalletResponse.md)**

### Errors

| Error Type                                         | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                | 400, 409                                           | application/json                                   |
| Moov.Sdk.Models.Errors.CreateWalletValidationError | 422                                                | application/json                                   |
| Moov.Sdk.Models.Errors.APIException                | 4XX, 5XX                                           | \*/\*                                              |

## List

List the wallets associated with a Moov account. 

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listWallets" method="get" path="/accounts/{accountID}/wallets" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListWalletsRequest req = new ListWalletsRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "25221c3c-8e3f-40db-8570-66d17b51014d",
};

var res = await sdk.Wallets.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListWalletsRequest](../../Models/Requests/ListWalletsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ListWalletsResponse](../../Models/Requests/ListWalletsResponse.md)**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Moov.Sdk.Models.Errors.ListWalletsValidationError | 422                                               | application/json                                  |
| Moov.Sdk.Models.Errors.APIException               | 4XX, 5XX                                          | \*/\*                                             |

## Get

Get information on a specific wallet (e.g., the available balance). 

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWallet" method="get" path="/accounts/{accountID}/wallets/{walletID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Wallets.GetAsync(
    accountID: "d04dfd44-8194-422f-a666-08d30c183f9a",
    walletID: "10a6bc37-8eeb-41c8-bf5f-77b40955542a"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |
| `WalletID`         | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetWalletResponse](../../Models/Requests/GetWalletResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

Update properties of an existing wallet such as name, description, status, or metadata.

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/wallets.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateWallet" method="patch" path="/accounts/{accountID}/wallets/{walletID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Wallets.UpdateAsync(
    walletID: "9f1c6e07-aae8-40e6-b290-502bb1bc486e",
    accountID: "e4aad2fb-201d-4390-b4d3-6de7716152e1",
    body: new PatchWallet() {
        Name = "My second wallet",
        Description = "My new description",
        Metadata = new Dictionary<string, string>() {
            { "optional", "metadata" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 | Example                                                                                                     |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `WalletID`                                                                                                  | *string*                                                                                                    | :heavy_check_mark:                                                                                          | Identifier for the wallet.                                                                                  |                                                                                                             |
| `AccountID`                                                                                                 | *string*                                                                                                    | :heavy_check_mark:                                                                                          | The Moov account ID the wallet belongs to.                                                                  |                                                                                                             |
| `Body`                                                                                                      | [PatchWallet](../../Models/Components/PatchWallet.md)                                                       | :heavy_check_mark:                                                                                          | N/A                                                                                                         | {<br/>"name": "My second wallet",<br/>"description": "My new description",<br/>"metadata": {<br/>"optional": "metadata"<br/>}<br/>} |

### Response

**[UpdateWalletResponse](../../Models/Requests/UpdateWalletResponse.md)**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError               | 400, 409                                          | application/json                                  |
| Moov.Sdk.Models.Errors.PatchWalletValidationError | 422                                               | application/json                                  |
| Moov.Sdk.Models.Errors.APIException               | 4XX, 5XX                                          | \*/\*                                             |