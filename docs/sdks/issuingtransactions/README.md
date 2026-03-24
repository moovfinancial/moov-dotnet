# IssuingTransactions

## Overview

### Available Operations

* [ListAuthorizations](#listauthorizations) - List issued card authorizations associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [GetAuthorization](#getauthorization) - Retrieves details of an authorization associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [ListAuthorizationEvents](#listauthorizationevents) - List card network and Moov platform events that affect the authorization and its hold on a wallet balance.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [List](#list) - List issued card transactions associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [Get](#get) - Retrieves details of an issued card transaction associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

## ListAuthorizations

List issued card authorizations associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listIssuedCardAuthorizations" method="get" path="/issuing/{accountID}/authorizations" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListIssuedCardAuthorizationsRequest req = new ListIssuedCardAuthorizationsRequest() {
    AccountID = "6465d95a-e945-4a49-8983-d74faa135bb4",
    Skip = 60,
    Count = 20,
};

var res = await sdk.IssuingTransactions.ListAuthorizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ListIssuedCardAuthorizationsRequest](../../Models/Requests/ListIssuedCardAuthorizationsRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[ListIssuedCardAuthorizationsResponse](../../Models/Requests/ListIssuedCardAuthorizationsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetAuthorization

Retrieves details of an authorization associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getIssuedCardAuthorization" method="get" path="/issuing/{accountID}/authorizations/{authorizationID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.IssuingTransactions.GetAuthorizationAsync(
    accountID: "0ccac2cc-6692-44a9-b0d1-35a1892c2db2",
    authorizationID: "d9ee8dde-b1eb-492f-bea1-d8e09bccbc52"
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `AccountID`                                                 | *string*                                                    | :heavy_check_mark:                                          | The Moov business account for which cards have been issued. |
| `AuthorizationID`                                           | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |

### Response

**[GetIssuedCardAuthorizationResponse](../../Models/Requests/GetIssuedCardAuthorizationResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ListAuthorizationEvents

List card network and Moov platform events that affect the authorization and its hold on a wallet balance.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listIssuedCardAuthorizationEvents" method="get" path="/issuing/{accountID}/authorizations/{authorizationID}/events" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.IssuingTransactions.ListAuthorizationEventsAsync(
    accountID: "f30f8cb3-64d8-4a5f-a427-965317fa559a",
    authorizationID: "e6a0946d-f3d8-451e-9b1c-5bc346a95dd6",
    skip: 60,
    count: 20
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `AccountID`                                                 | *string*                                                    | :heavy_check_mark:                                          | The Moov business account for which cards have been issued. |                                                             |
| `AuthorizationID`                                           | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |                                                             |
| `Skip`                                                      | *long*                                                      | :heavy_minus_sign:                                          | N/A                                                         | 60                                                          |
| `Count`                                                     | *long*                                                      | :heavy_minus_sign:                                          | N/A                                                         | 20                                                          |

### Response

**[ListIssuedCardAuthorizationEventsResponse](../../Models/Requests/ListIssuedCardAuthorizationEventsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## List

List issued card transactions associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listIssuedCardTransactions" method="get" path="/issuing/{accountID}/card-transactions" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListIssuedCardTransactionsRequest req = new ListIssuedCardTransactionsRequest() {
    AccountID = "4efcb497-f915-4b6e-b973-e5e5bcc1fd34",
    Skip = 60,
    Count = 20,
};

var res = await sdk.IssuingTransactions.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListIssuedCardTransactionsRequest](../../Models/Requests/ListIssuedCardTransactionsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListIssuedCardTransactionsResponse](../../Models/Requests/ListIssuedCardTransactionsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Retrieves details of an issued card transaction associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getIssuedCardTransaction" method="get" path="/issuing/{accountID}/card-transactions/{cardTransactionID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.IssuingTransactions.GetAsync(
    accountID: "b2b6e23c-a5aa-46a9-adb7-d12876e47288",
    cardTransactionID: "d5a1aab9-eb96-409a-ab95-88ac99cf00a5"
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `AccountID`                                                 | *string*                                                    | :heavy_check_mark:                                          | The Moov business account for which cards have been issued. |
| `CardTransactionID`                                         | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |

### Response

**[GetIssuedCardTransactionResponse](../../Models/Requests/GetIssuedCardTransactionResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |