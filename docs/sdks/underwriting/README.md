# Underwriting

## Overview

### Available Operations

* [Get](#get) - Retrieve underwriting associated with a given Moov account. 

Read our [underwriting guide](https://docs.moov.io/guides/accounts/requirements/underwriting/) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [Upsert](#upsert) - Create or update the account's underwriting.

Read our [underwriting guide](https://docs.moov.io/guides/accounts/requirements/underwriting/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

## Get

Retrieve underwriting associated with a given Moov account. 

Read our [underwriting guide](https://docs.moov.io/guides/accounts/requirements/underwriting/) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUnderwriting" method="get" path="/accounts/{accountID}/underwriting" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Underwriting.GetAsync(accountID: "efe07546-f697-4da5-bf73-d9987efd4cdd");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetUnderwritingResponse](../../Models/Requests/GetUnderwritingResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Upsert

Create or update the account's underwriting.

Read our [underwriting guide](https://docs.moov.io/guides/accounts/requirements/underwriting/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="upsertUnderwriting" method="put" path="/accounts/{accountID}/underwriting" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Underwriting.UpsertAsync(
    accountID: "371bf394-45df-4ba8-a615-ad5483b1f963",
    body: new UpdateUnderwriting() {
        AverageTransactionSize = 622191,
        MaxTransactionSize = 123692,
        AverageMonthlyTransactionVolume = 438164,
        VolumeByCustomerType = new VolumeByCustomerType() {
            BusinessToBusinessPercentage = 671399,
            ConsumerToBusinessPercentage = 482010,
        },
        CardVolumeDistribution = new CardVolumeDistribution() {
            EcommercePercentage = 47450,
            CardPresentPercentage = 146275,
            MailOrPhonePercentage = 309315,
            DebtRepaymentPercentage = 990303,
        },
        Fulfillment = new FulfillmentDetails() {
            HasPhysicalGoods = true,
            IsShippingProduct = true,
            ShipmentDurationDays = 388451,
            ReturnPolicy = ReturnPolicyType.Other,
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AccountID`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Body`                                                              | [UpdateUnderwriting](../../Models/Components/UpdateUnderwriting.md) | :heavy_check_mark:                                                  | N/A                                                                 |

### Response

**[UpsertUnderwritingResponse](../../Models/Requests/UpsertUnderwritingResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError            | 400, 409                                       | application/json                               |
| Moov.Sdk.Models.Errors.UpdateUnderwritingError | 422                                            | application/json                               |
| Moov.Sdk.Models.Errors.APIException            | 4XX, 5XX                                       | \*/\*                                          |