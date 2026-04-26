# GooglePay

## Overview

### Available Operations

* [LinkToken](#linktoken) - Connect a Google Pay token to the specified account.

The `paymentMethodData` field should contain the `paymentMethodData` property from Google Pay's
[PaymentData](https://developers.google.com/pay/api/web/reference/response-objects#PaymentData) response,
passed through unmodified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/cards.write` scope.

## LinkToken

Connect a Google Pay token to the specified account.

The `paymentMethodData` field should contain the `paymentMethodData` property from Google Pay's
[PaymentData](https://developers.google.com/pay/api/web/reference/response-objects#PaymentData) response,
passed through unmodified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/cards.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="linkGooglePayToken" method="post" path="/accounts/{accountID}/google-pay/tokens" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.GooglePay.LinkTokenAsync(
    accountID: "<id>",
    body: new LinkGooglePay() {
        MerchantAccountID = "c5f78a7e-2fb0-4e4a-bcf0-9e1f8b0e5c7a",
        PaymentMethodData = new GooglePayPaymentMethodData() {
            Type = GooglePayPaymentMethodDataType.Card,
            Info = new GooglePayCardInfo() {
                CardNetwork = CardNetwork.Visa,
                CardDetails = "1234",
                CardFundingSource = CardFundingSource.Debit,
                BillingAddress = new GooglePayBillingAddress() {
                    CountryCode = "US",
                },
            },
            TokenizationData = new GooglePayTokenizationData() {
                Type = GooglePayTokenizationDataType.PaymentGateway,
                Token = "<value>",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `AccountID`                                               | *string*                                                  | :heavy_check_mark:                                        | ID of the Moov account representing the cardholder.       |
| `Body`                                                    | [LinkGooglePay](../../Models/Components/LinkGooglePay.md) | :heavy_check_mark:                                        | N/A                                                       |

### Response

**[LinkGooglePayTokenResponse](../../Models/Requests/LinkGooglePayTokenResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError       | 400, 409                                  | application/json                          |
| Moov.Sdk.Models.Errors.LinkGooglePayError | 422                                       | application/json                          |
| Moov.Sdk.Models.Errors.APIException       | 4XX, 5XX                                  | \*/\*                                     |