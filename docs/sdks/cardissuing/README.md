# CardIssuing

## Overview

### Available Operations

* [Request](#request) - Request a virtual card be issued.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.write` scope.
* [List](#list) - List Moov issued cards existing for the account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [Get](#get) - Retrieve a single issued card associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [Update](#update) - Update a Moov issued card.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/issued-cards.write` scope.
* [GetFull](#getfull) - Get issued card with PAN, CVV, and expiration. 

Only use this endpoint if you have provided Moov with a copy of your PCI attestation of compliance.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read-secure` scope.

## Request

Request a virtual card be issued.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="requestCard" method="post" path="/issuing/{accountID}/issued-cards" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.CardIssuing.RequestAsync(
    accountID: "4d9ac71a-efcc-4bdf-bcfe-d710ca654e3e",
    body: new RequestCard() {
        FundingWalletID = "fd98e3b2-696f-4f67-9250-17b3474ababf",
        AuthorizedUser = new CreateAuthorizedUser() {
            FirstName = "Milton",
            LastName = "Stiedemann",
            BirthDate = new BirthDate() {
                Day = 9,
                Month = 11,
                Year = 1989,
            },
        },
        FormFactor = IssuedCardFormFactor.Virtual,
        Expiration = new CardExpiration() {
            Month = "01",
            Year = "21",
        },
        Controls = new IssuingControls() {
            VelocityLimits = new List<IssuingVelocityLimit>() {
                new IssuingVelocityLimit() {
                    Amount = 10000,
                    Interval = IssuingIntervalLimit.PerTransaction,
                },
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `AccountID`                                                   | *string*                                                      | :heavy_check_mark:                                            | The Moov business account for which the card is to be issued. |
| `Body`                                                        | [RequestCard](../../Models/Components/RequestCard.md)         | :heavy_check_mark:                                            | N/A                                                           |

### Response

**[RequestCardResponse](../../Models/Requests/RequestCardResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError     | 400                                     | application/json                        |
| Moov.Sdk.Models.Errors.RequestCardError | 422                                     | application/json                        |
| Moov.Sdk.Models.Errors.APIException     | 4XX, 5XX                                | \*/\*                                   |

## List

List Moov issued cards existing for the account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listIssuedCards" method="get" path="/issuing/{accountID}/issued-cards" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.CardIssuing.ListAsync(
    accountID: "17c958e0-3abe-46e5-8afb-98742f1fb8ac",
    skip: 60,
    count: 20
);

// handle response
```

### Parameters

| Parameter                                                                                                                 | Type                                                                                                                      | Required                                                                                                                  | Description                                                                                                               | Example                                                                                                                   |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                               | *string*                                                                                                                  | :heavy_check_mark:                                                                                                        | The Moov business account for which the cards have been issued.                                                           |                                                                                                                           |
| `Skip`                                                                                                                    | *long*                                                                                                                    | :heavy_minus_sign:                                                                                                        | N/A                                                                                                                       | 60                                                                                                                        |
| `Count`                                                                                                                   | *long*                                                                                                                    | :heavy_minus_sign:                                                                                                        | N/A                                                                                                                       | 20                                                                                                                        |
| `States`                                                                                                                  | List<[IssuedCardState](../../Models/Components/IssuedCardState.md)>                                                       | :heavy_minus_sign:                                                                                                        | Optional, comma-separated states to filter the Moov list issued cards response. For example `active,pending-verification` |                                                                                                                           |

### Response

**[ListIssuedCardsResponse](../../Models/Requests/ListIssuedCardsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Retrieve a single issued card associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getIssuedCard" method="get" path="/issuing/{accountID}/issued-cards/{issuedCardID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.CardIssuing.GetAsync(
    accountID: "4fde8da4-b6c5-4379-82a2-4ff6a742e41a",
    issuedCardID: "d04885c9-ea6b-43a7-9186-63d9fbd57716"
);

// handle response
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `AccountID`                                              | *string*                                                 | :heavy_check_mark:                                       | The Moov business account for which the card was issued. |
| `IssuedCardID`                                           | *string*                                                 | :heavy_check_mark:                                       | N/A                                                      |

### Response

**[GetIssuedCardResponse](../../Models/Requests/GetIssuedCardResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

Update a Moov issued card.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/issued-cards.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateIssuedCard" method="patch" path="/issuing/{accountID}/issued-cards/{issuedCardID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.CardIssuing.UpdateAsync(
    accountID: "44db31bc-2813-424b-9b8c-2d3f5f1300e3",
    issuedCardID: "69ca2a7e-7bbc-4176-9d0c-2a1aa7143006",
    body: new UpdateIssuedCard() {
        AuthorizedUser = new CreateAuthorizedUserUpdate() {
            BirthDate = new BirthDateUpdate() {
                Day = 9,
                Month = 11,
                Year = 1989,
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `AccountID`                                                     | *string*                                                        | :heavy_check_mark:                                              | The Moov business account for which the card was issued.        |
| `IssuedCardID`                                                  | *string*                                                        | :heavy_check_mark:                                              | N/A                                                             |
| `Body`                                                          | [UpdateIssuedCard](../../Models/Components/UpdateIssuedCard.md) | :heavy_check_mark:                                              | N/A                                                             |

### Response

**[UpdateIssuedCardResponse](../../Models/Requests/UpdateIssuedCardResponse.md)**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError          | 400, 409                                     | application/json                             |
| Moov.Sdk.Models.Errors.UpdateIssuedCardError | 422                                          | application/json                             |
| Moov.Sdk.Models.Errors.APIException          | 4XX, 5XX                                     | \*/\*                                        |

## GetFull

Get issued card with PAN, CVV, and expiration. 

Only use this endpoint if you have provided Moov with a copy of your PCI attestation of compliance.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read-secure` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFullIssuedCard" method="get" path="/issuing/{accountID}/issued-cards/{issuedCardID}/details" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.CardIssuing.GetFullAsync(
    accountID: "512052fb-5e2c-4d24-98dd-fa893c9d8a03",
    issuedCardID: "087ecc51-11fe-4471-a3bb-44f20c1e87a9"
);

// handle response
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `AccountID`                                              | *string*                                                 | :heavy_check_mark:                                       | The Moov business account for which the card was issued. |
| `IssuedCardID`                                           | *string*                                                 | :heavy_check_mark:                                       | N/A                                                      |

### Response

**[GetFullIssuedCardResponse](../../Models/Requests/GetFullIssuedCardResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |