# PaymentLinks

## Overview

### Available Operations

* [Create](#create) - Create a payment link that allows an end user to make a payment on Moov's hosted payment link page.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [List](#list) - List all the payment links created under a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Get](#get) - Retrieve a payment link by code.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Update](#update) - Update a payment link.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [Disable](#disable) - Disable a payment link.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [GetQRCode](#getqrcode) - Retrieve the payment link encoded in a QR code. 

Use the `Accept` header to specify the format of the response. Supported formats are `application/json` and `image/png`.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

## Create

Create a payment link that allows an end user to make a payment on Moov's hosted payment link page.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPaymentLink" method="post" path="/accounts/{accountID}/payment-links" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.PaymentLinks.CreateAsync(
    accountID: "cc1d04a8-03b1-4600-b675-e6180d574074",
    body: new CreatePaymentLink() {
        PartnerAccountID = "d290f1ee-6c54-4b01-90e6-d701748f0851",
        MerchantPaymentMethodID = "4c4e7f8e-81f4-4f3d-8f6f-6f6e7f8e4c4e",
        Amount = new Amount() {
            Currency = "USD",
            Value = 10000,
        },
        Display = new PaymentLinkDisplayOptions() {
            Title = "Example Payment Link",
            Description = "This is an example payment link.",
            CallToAction = CallToAction.Pay,
        },
        Customer = new PaymentLinkCustomerOptions() {
            RequirePhone = true,
            TippingEnabled = true,
        },
        Payment = new PaymentLinkPaymentDetails() {
            AllowedMethods = new List<CollectionPaymentMethodType>() {
                CollectionPaymentMethodType.CardPayment,
                CollectionPaymentMethodType.AchDebitCollect,
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                          | Example                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                   | The merchant account ID.                                                                                                                                                                                                                                                                                                                                                                                                                             |                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                               | [CreatePaymentLink](../../Models/Components/CreatePaymentLink.md)                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                   | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                  | {<br/>"partnerAccountID": "d290f1ee-6c54-4b01-90e6-d701748f0851",<br/>"merchantPaymentMethodID": "4c4e7f8e-81f4-4f3d-8f6f-6f6e7f8e4c4e",<br/>"amount": {<br/>"currency": "USD",<br/>"value": 10000<br/>},<br/>"display": {<br/>"title": "Example Payment Link",<br/>"description": "This is an example payment link.",<br/>"callToAction": "pay"<br/>},<br/>"customer": {<br/>"requirePhone": true,<br/>"tippingEnabled": true<br/>},<br/>"payment": {<br/>"allowedMethods": [<br/>"card-payment",<br/>"ach-debit-collect"<br/>]<br/>}<br/>} |

### Response

**[CreatePaymentLinkResponse](../../Models/Requests/CreatePaymentLinkResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError           | 400, 409                                      | application/json                              |
| Moov.Sdk.Models.Errors.CreatePaymentLinkError | 422                                           | application/json                              |
| Moov.Sdk.Models.Errors.APIException           | 4XX, 5XX                                      | \*/\*                                         |

## List

List all the payment links created under a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPaymentLinks" method="get" path="/accounts/{accountID}/payment-links" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.PaymentLinks.ListAsync(
    accountID: "d1039e6d-21ee-4a29-8adf-1dd2a6625a0d",
    skip: 60,
    count: 20
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AccountID`                                                         | *string*                                                            | :heavy_check_mark:                                                  | The merchant account ID.                                            |                                                                     |
| `Skip`                                                              | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 | 60                                                                  |
| `Count`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 | 20                                                                  |
| `Types`                                                             | List<[PaymentLinkType](../../Models/Components/PaymentLinkType.md)> | :heavy_minus_sign:                                                  | A comma-separated list of payment link types to filter results.     |                                                                     |

### Response

**[ListPaymentLinksResponse](../../Models/Requests/ListPaymentLinksResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Retrieve a payment link by code.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPaymentLink" method="get" path="/accounts/{accountID}/payment-links/{paymentLinkCode}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.PaymentLinks.GetAsync(
    accountID: "323f95b1-3798-4203-8a73-5c8668a9226e",
    paymentLinkCode: "uc7ZYKrMhi"
);

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              | Example                  |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `AccountID`              | *string*                 | :heavy_check_mark:       | The merchant account ID. |                          |
| `PaymentLinkCode`        | *string*                 | :heavy_check_mark:       | N/A                      | uc7ZYKrMhi               |

### Response

**[GetPaymentLinkResponse](../../Models/Requests/GetPaymentLinkResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

Update a payment link.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePaymentLink" method="patch" path="/accounts/{accountID}/payment-links/{paymentLinkCode}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.PaymentLinks.UpdateAsync(
    accountID: "ddad6613-2350-446a-883b-f76abb2cd4ea",
    paymentLinkCode: "uc7ZYKrMhi",
    body: new UpdatePaymentLink() {
        Amount = new AmountUpdate() {
            Currency = "USD",
            Value = 12099,
        },
        Customer = new PaymentLinkCustomerOptions() {
            RequireAddress = true,
            RequirePhone = true,
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                       | *string*                                                                                                          | :heavy_check_mark:                                                                                                | The merchant account ID.                                                                                          |                                                                                                                   |
| `PaymentLinkCode`                                                                                                 | *string*                                                                                                          | :heavy_check_mark:                                                                                                | N/A                                                                                                               | uc7ZYKrMhi                                                                                                        |
| `Body`                                                                                                            | [UpdatePaymentLink](../../Models/Components/UpdatePaymentLink.md)                                                 | :heavy_check_mark:                                                                                                | N/A                                                                                                               | {<br/>"amount": {<br/>"currency": "USD",<br/>"value": 12099<br/>},<br/>"customer": {<br/>"requirePhone": true,<br/>"requireAddress": true<br/>}<br/>} |

### Response

**[UpdatePaymentLinkResponse](../../Models/Requests/UpdatePaymentLinkResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError           | 400, 409                                      | application/json                              |
| Moov.Sdk.Models.Errors.UpdatePaymentLinkError | 422                                           | application/json                              |
| Moov.Sdk.Models.Errors.APIException           | 4XX, 5XX                                      | \*/\*                                         |

## Disable

Disable a payment link.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="disablePaymentLink" method="delete" path="/accounts/{accountID}/payment-links/{paymentLinkCode}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.PaymentLinks.DisableAsync(
    accountID: "c1cf000d-0dd9-4dec-bd5e-a88e135adf82",
    paymentLinkCode: "uc7ZYKrMhi"
);

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              | Example                  |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `AccountID`              | *string*                 | :heavy_check_mark:       | The merchant account ID. |                          |
| `PaymentLinkCode`        | *string*                 | :heavy_check_mark:       | N/A                      | uc7ZYKrMhi               |

### Response

**[DisablePaymentLinkResponse](../../Models/Requests/DisablePaymentLinkResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetQRCode

Retrieve the payment link encoded in a QR code. 

Use the `Accept` header to specify the format of the response. Supported formats are `application/json` and `image/png`.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPaymentLinkQRCode" method="get" path="/accounts/{accountID}/payment-links/{paymentLinkCode}/qrcode" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.PaymentLinks.GetQRCodeAsync(
    accountID: "2f01a42a-aa5a-424f-9f47-6f8999ed05dc",
    paymentLinkCode: "uc7ZYKrMhi"
);

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              | Example                  |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `AccountID`              | *string*                 | :heavy_check_mark:       | The merchant account ID. |                          |
| `PaymentLinkCode`        | *string*                 | :heavy_check_mark:       | N/A                      | uc7ZYKrMhi               |

### Response

**[GetPaymentLinkQRCodeResponse](../../Models/Requests/GetPaymentLinkQRCodeResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |