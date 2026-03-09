# ApplePay

## Overview

### Available Operations

* [RegisterMerchantDomains](#registermerchantdomains) - Add domains to be registered with Apple Pay.

Any domains that will be used to accept payments must first be [verified](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) 
with Apple.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.
* [UpdateMerchantDomains](#updatemerchantdomains) - Add or remove domains to be registered with Apple Pay.

Any domains that will be used to accept payments must first be [verified](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains)
with Apple.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.
* [GetMerchantDomains](#getmerchantdomains) - Get domains registered with Apple Pay. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.read` scope.
* [CreateSession](#createsession) - Create a session with Apple Pay to facilitate a payment. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 
A successful response from this endpoint should be passed through to Apple Pay unchanged. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.
* [LinkToken](#linktoken) - Connect an Apple Pay token to the specified account. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 
The `token` data is defined by Apple Pay and should be passed through from Apple Pay's response unmodified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/cards.write` scope.

## RegisterMerchantDomains

Add domains to be registered with Apple Pay.

Any domains that will be used to accept payments must first be [verified](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) 
with Apple.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="registerApplePayMerchantDomains" method="post" path="/accounts/{accountID}/apple-pay/domains" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(
    xMoovVersion: "<value>",
    security: new Security() {
        Username = "",
        Password = "",
    }
);

var res = await sdk.ApplePay.RegisterMerchantDomainsAsync(
    accountID: "60825531-8c7e-421c-8014-019c6603250c",
    body: new RegisterApplePayMerchantDomains() {
        Domains = new List<string>() {
            "checkout.classbooker.dev",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | ID of the Moov account representing the merchant.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | [RegisterApplePayMerchantDomains](../../Models/Components/RegisterApplePayMerchantDomains.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `dev` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[RegisterApplePayMerchantDomainsResponse](../../Models/Requests/RegisterApplePayMerchantDomainsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400                                 | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## UpdateMerchantDomains

Add or remove domains to be registered with Apple Pay.

Any domains that will be used to accept payments must first be [verified](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains)
with Apple.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateApplePayMerchantDomains" method="patch" path="/accounts/{accountID}/apple-pay/domains" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(
    xMoovVersion: "<value>",
    security: new Security() {
        Username = "",
        Password = "",
    }
);

var res = await sdk.ApplePay.UpdateMerchantDomainsAsync(
    accountID: "34b1c132-91d4-4676-9864-87e1d961d56d",
    body: new UpdateApplePayMerchantDomains() {
        AddDomains = new List<string>() {
            "pay.classbooker.dev",
        },
        RemoveDomains = new List<string>() {
            "checkout.classbooker.dev",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | ID of the Moov account representing the merchant.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | [UpdateApplePayMerchantDomains](../../Models/Components/UpdateApplePayMerchantDomains.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `dev` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[UpdateApplePayMerchantDomainsResponse](../../Models/Requests/UpdateApplePayMerchantDomainsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400                                 | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetMerchantDomains

Get domains registered with Apple Pay. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getApplePayMerchantDomains" method="get" path="/accounts/{accountID}/apple-pay/domains" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(
    xMoovVersion: "<value>",
    security: new Security() {
        Username = "",
        Password = "",
    }
);

var res = await sdk.ApplePay.GetMerchantDomainsAsync(accountID: "28704d00-d07b-47db-9e54-016a9713d697");

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | ID of the Moov account representing the merchant.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `dev` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[GetApplePayMerchantDomainsResponse](../../Models/Requests/GetApplePayMerchantDomainsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## CreateSession

Create a session with Apple Pay to facilitate a payment. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 
A successful response from this endpoint should be passed through to Apple Pay unchanged. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createApplePaySession" method="post" path="/accounts/{accountID}/apple-pay/sessions" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(
    xMoovVersion: "<value>",
    security: new Security() {
        Username = "",
        Password = "",
    }
);

var res = await sdk.ApplePay.CreateSessionAsync(
    accountID: "32ab62ca-7afd-4f49-89cb-0bb237258f23",
    body: new CreateApplePaySession() {
        Domain = "checkout.classbooker.dev",
        DisplayName = "Fay11",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | ID of the Moov account representing the merchant.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | [CreateApplePaySession](../../Models/Components/CreateApplePaySession.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `dev` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[CreateApplePaySessionResponse](../../Models/Requests/CreateApplePaySessionResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409, 422                       | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## LinkToken

Connect an Apple Pay token to the specified account. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 
The `token` data is defined by Apple Pay and should be passed through from Apple Pay's response unmodified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/cards.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="linkApplePayToken" method="post" path="/accounts/{accountID}/apple-pay/tokens" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(
    xMoovVersion: "<value>",
    security: new Security() {
        Username = "",
        Password = "",
    }
);

var res = await sdk.ApplePay.LinkTokenAsync(
    accountID: "bf498c07-3852-4060-b561-bf992e26a851",
    body: new LinkApplePay() {
        Token = new LinkApplePayToken() {
            PaymentData = new LinkApplePaymentData() {
                Version = "EC_v1",
                Data = "3+f4oOTwPa6f1UZ6tG...CE=",
                Signature = "MIAGCSqGSIb3DQ.AAAA==",
                Header = new ApplePayHeader() {
                    EphemeralPublicKey = "MFkwEK...Md==",
                    PublicKeyHash = "l0CnXdMv...D1I=",
                    TransactionId = "32b...4f3",
                },
            },
            PaymentMethod = new LinkApplePaymentMethod() {
                DisplayName = "Visa 1234",
                Network = "Visa",
                Type = "debit",
            },
            TransactionIdentifier = "32b...4f3",
        },
        BillingContact = new AppleBillingContact() {
            AddressLines = new List<string>() {
                "123 Sesame Street",
            },
            Locality = "Phoenix",
            PostalCode = "30345",
            AdministrativeArea = "AZ",
            CountryCode = "US",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | ID of the Moov account representing the cardholder.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | [LinkApplePay](../../Models/Components/LinkApplePay.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `dev` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[LinkApplePayTokenResponse](../../Models/Requests/LinkApplePayTokenResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError      | 400, 409                                 | application/json                         |
| Moov.Sdk.Models.Errors.LinkApplePayError | 422                                      | application/json                         |
| Moov.Sdk.Models.Errors.APIException      | 4XX, 5XX                                 | \*/\*                                    |