# GooglePay

## Overview

### Available Operations

* [LinkToken](#linktoken) - Connect a Google Pay token to the specified account.

The `token` data is defined by Google Pay and should be passed through from Google Pay's response unmodified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/cards.write` scope.

## LinkToken

Connect a Google Pay token to the specified account.

The `token` data is defined by Google Pay and should be passed through from Google Pay's response unmodified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/cards.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="linkGooglePayToken" method="post" path="/accounts/{accountID}/google-pay/tokens" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.GooglePay.LinkTokenAsync(
    accountID: "<id>",
    body: new LinkGooglePay() {
        Token = new GooglePayToken() {
            ProtocolVersion = "ECv2",
            Signature = "<value>",
            IntermediateSigningKey = new GooglePayIntermediateSigningKey() {
                SignedKey = "<value>",
                Signatures = new List<string>() {
                    "<value 1>",
                    "<value 2>",
                    "<value 3>",
                },
            },
            SignedMessage = "<value>",
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