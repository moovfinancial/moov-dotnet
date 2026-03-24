# FeePlans

## Overview

### Available Operations

* [ListFeePlanAgreements](#listfeeplanagreements) - List all fee plan agreements associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [CreateFeePlanAgreements](#createfeeplanagreements) - Creates the subscription of a fee plan to a merchant account. Merchants are required to accept the fee plan terms prior to activation.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.
* [ListFeePlans](#listfeeplans) - List all fee plans available for use by an account. This is intended to be used by an account when 
selecting a fee plan to apply to a connected account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [ListFeeRevenue](#listfeerevenue) - Used by a partner. Retrieve revenue generated from merchant fees.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [RetrieveFees](#retrievefees) - Retrieve fees assessed to an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [ListFeesFetch](#listfeesfetch) - List fees associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [ListPartnerPricingAgreements](#listpartnerpricingagreements) - List all partner pricing agreements associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [ListResiduals](#listresiduals) - List all residuals associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [GetResidual](#getresidual) - Get a residual associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [ListResidualFees](#listresidualfees) - List all fees associated with a residual.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

## ListFeePlanAgreements

List all fee plan agreements associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFeePlanAgreements" method="get" path="/accounts/{accountID}/fee-plan-agreements" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListFeePlanAgreementsRequest req = new ListFeePlanAgreementsRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "93c43634-5477-42a7-972d-01fa76a09e17",
};

var res = await sdk.FeePlans.ListFeePlanAgreementsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListFeePlanAgreementsRequest](../../Models/Requests/ListFeePlanAgreementsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListFeePlanAgreementsResponse](../../Models/Requests/ListFeePlanAgreementsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## CreateFeePlanAgreements

Creates the subscription of a fee plan to a merchant account. Merchants are required to accept the fee plan terms prior to activation.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createFeePlanAgreements" method="post" path="/accounts/{accountID}/fee-plan-agreements" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.FeePlans.CreateFeePlanAgreementsAsync(
    accountID: "409c6b4b-e622-40c2-9dc4-fb494e555723",
    body: new CreateFeePlanAgreement() {
        PlanID = "19801f96-ea27-4610-b4d1-8c6b46f37928",
    }
);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `AccountID`                                                                 | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `Body`                                                                      | [CreateFeePlanAgreement](../../Models/Components/CreateFeePlanAgreement.md) | :heavy_check_mark:                                                          | N/A                                                                         |

### Response

**[CreateFeePlanAgreementsResponse](../../Models/Requests/CreateFeePlanAgreementsResponse.md)**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError          | 400, 409                                     | application/json                             |
| Moov.Sdk.Models.Errors.FeePlanAgreementError | 422                                          | application/json                             |
| Moov.Sdk.Models.Errors.APIException          | 4XX, 5XX                                     | \*/\*                                        |

## ListFeePlans

List all fee plans available for use by an account. This is intended to be used by an account when 
selecting a fee plan to apply to a connected account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFeePlans" method="get" path="/accounts/{accountID}/fee-plans" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.FeePlans.ListFeePlansAsync(accountID: "b3d59179-f74e-4ee8-b123-33220b3c7d4b");

// handle response
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `AccountID`                                                  | *string*                                                     | :heavy_check_mark:                                           | N/A                                                          |
| `PlanIDs`                                                    | List<*string*>                                               | :heavy_minus_sign:                                           | A comma-separated list of plan IDs to filter the results by. |

### Response

**[ListFeePlansResponse](../../Models/Requests/ListFeePlansResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ListFeeRevenue

Used by a partner. Retrieve revenue generated from merchant fees.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFeeRevenue" method="get" path="/accounts/{accountID}/fee-revenue" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListFeeRevenueRequest req = new ListFeeRevenueRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "795465fb-f955-40e7-9d48-4a6d6fbdbdf2",
};

var res = await sdk.FeePlans.ListFeeRevenueAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListFeeRevenueRequest](../../Models/Requests/ListFeeRevenueRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListFeeRevenueResponse](../../Models/Requests/ListFeeRevenueResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## RetrieveFees

Retrieve fees assessed to an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="retrieveFees" method="get" path="/accounts/{accountID}/fees" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

RetrieveFeesRequest req = new RetrieveFeesRequest() {
    AccountID = "89daf02d-b6b3-4fbf-b20d-5bf967324682",
    Skip = 60,
    Count = 20,
};

var res = await sdk.FeePlans.RetrieveFeesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [RetrieveFeesRequest](../../Models/Requests/RetrieveFeesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[RetrieveFeesResponse](../../Models/Requests/RetrieveFeesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ListFeesFetch

List fees associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFeesFetch" method="post" path="/accounts/{accountID}/fees/.fetch" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.FeePlans.ListFeesFetchAsync(accountID: "55c34e26-269d-4872-8e42-0fa83e3f4b10");

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `AccountID`                                                                               | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `Body`                                                                                    | [Models.Components.ListFeesFetchRequest](../../Models/Components/ListFeesFetchRequest.md) | :heavy_minus_sign:                                                                        | N/A                                                                                       |

### Response

**[ListFeesFetchResponse](../../Models/Requests/ListFeesFetchResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ListPartnerPricingAgreements

List all partner pricing agreements associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPartnerPricingAgreements" method="get" path="/accounts/{accountID}/partner-pricing-agreements" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListPartnerPricingAgreementsRequest req = new ListPartnerPricingAgreementsRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "123bfe5e-2288-4146-9d8a-4c07264c3758",
};

var res = await sdk.FeePlans.ListPartnerPricingAgreementsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ListPartnerPricingAgreementsRequest](../../Models/Requests/ListPartnerPricingAgreementsRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[ListPartnerPricingAgreementsResponse](../../Models/Requests/ListPartnerPricingAgreementsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ListResiduals

List all residuals associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listResiduals" method="get" path="/accounts/{accountID}/residuals" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListResidualsRequest req = new ListResidualsRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "8b40b967-ae12-4851-8be2-7b0c39978ce7",
};

var res = await sdk.FeePlans.ListResidualsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListResidualsRequest](../../Models/Requests/ListResidualsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListResidualsResponse](../../Models/Requests/ListResidualsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetResidual

Get a residual associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getResidual" method="get" path="/accounts/{accountID}/residuals/{residualID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.FeePlans.GetResidualAsync(
    accountID: "4c308842-45d1-49c1-98be-7299848b1e20",
    residualID: "5f30e43d-1fa8-4834-8788-05a3c27a40d4"
);

// handle response
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `AccountID`                                              | *string*                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `ResidualID`                                             | *string*                                                 | :heavy_check_mark:                                       | Unique identifier for this residual payment calculation. |

### Response

**[GetResidualResponse](../../Models/Requests/GetResidualResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ListResidualFees

List all fees associated with a residual.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listResidualFees" method="get" path="/accounts/{accountID}/residuals/{residualID}/fees" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListResidualFeesRequest req = new ListResidualFeesRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "6b95293f-c3e7-42b5-98b7-fd9cc8d49685",
    ResidualID = "8ecb1a63-25e0-41e7-a9c7-bb8a1cf63d1c",
};

var res = await sdk.FeePlans.ListResidualFeesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListResidualFeesRequest](../../Models/Requests/ListResidualFeesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListResidualFeesResponse](../../Models/Requests/ListResidualFeesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |