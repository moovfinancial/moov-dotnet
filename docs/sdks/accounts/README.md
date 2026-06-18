# Accounts

## Overview

### Available Operations

* [Create](#create) - You can create business or individual accounts for your users (i.e., customers, merchants) by passing the required information to Moov. Requirements differ per account type and requested [capabilities](https://docs.moov.io/guides/accounts/capabilities/reference/).

The `transfers` capability is automatically requested for every account. If you request any capability beyond `transfers` (for example, `send-funds.ach`, `collect-funds.card-payments`), you'll need to:
  + Send Moov the user's [platform terms of service agreement](https://docs.moov.io/guides/accounts/requirements/platform-agreement/) acceptance. This can be done at account creation, or by [patching](https://docs.moov.io/api/moov-accounts/accounts/patch/) the account using the `termsOfService` field.
  + Fulfill the [verification and underwriting requirements](https://docs.moov.io/guides/accounts/requirements/) for each requested capability. A capability isn't enabled until its requirements pass — check the capability's status to see what's still outstanding.

If you're creating a business account, depending on the business type, you'll also need to:
  + Provide [business representatives](https://docs.moov.io/api/moov-accounts/representatives/) after creating the account.
  + [Patch](https://docs.moov.io/api/moov-accounts/accounts/patch/) the account to indicate that business representative ownership information is complete.

Visit our documentation to read more about [creating accounts](https://docs.moov.io/guides/accounts/create-accounts/) and [verification requirements](https://docs.moov.io/guides/accounts/requirements/identity-verification/). Note that the `mode` field (for production or sandbox) is only required when creating a Partner account. All other account requests will ignore the mode field and be set to the calling Partner account's mode.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need to specify the `/accounts.write` scope.
* [List](#list) - List or search accounts to which the caller is connected.

All supported query parameters are optional. If none are provided the response will include all connected accounts.
Pagination is supported via the `skip` and `count` query parameters. Searching by name and email will overlap and 
return results based on relevance. Accounts with AccountType `guest` will not be included in the response.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts.read` scope.
* [Get](#get) - Retrieves details for the account with the specified ID.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts/{accountID}/profile.read` scope.
* [Update](#update) - When **can** profile data be updated:
  + For unverified accounts, all profile data can be edited.
  + During the verification process, missing or incomplete profile data can be edited.
  + Verified accounts can only add missing profile data.

  When **can't** profile data be updated:
  + Verified accounts cannot change any existing profile data.

If you need to update information in a locked state, please contact Moov support.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need
to specify the `/accounts/{accountID}/profile.write` scope.
* [Disconnect](#disconnect) - This will sever the connection between you and the account specified and it will no longer be listed as 
active in the list of accounts. This also means you'll only have read-only access to the account going 
forward for reporting purposes.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.disconnect` scope.
* [ListConnected](#listconnected) - List or search accounts to which the caller is connected.

All supported query parameters are optional. If none are provided the response will include all connected accounts.
Pagination is supported via the `skip` and `count` query parameters. Searching by name and email will overlap and 
return results based on relevance. Accounts with AccountType `guest` will not be included in the response.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts.read` scope.
* [Connect](#connect) - Shares access scopes from the account specified to the caller, establishing a connection 
between the two accounts with the specified permissions.
* [GetCountries](#getcountries) - Retrieve the specified countries of operation for an account. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [AssignCountries](#assigncountries) - Assign the countries of operation for an account.

This endpoint will always overwrite the previously assigned values. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.
* [GetMerchantProcessingAgreement](#getmerchantprocessingagreement) - Retrieve a merchant account's processing agreement.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [GetTermsOfServiceToken](#gettermsofservicetoken) - Generates a non-expiring token that can then be used to accept Moov's terms of service. 

This token can only be generated via API. Any Moov account requesting the collect funds, send funds, wallet, 
or card issuing capabilities must accept Moov's terms of service, then have the generated terms of service 
token patched to the account. Read more in our [documentation](https://docs.moov.io/guides/accounts/requirements/platform-agreement/).

## Create

You can create business or individual accounts for your users (i.e., customers, merchants) by passing the required information to Moov. Requirements differ per account type and requested [capabilities](https://docs.moov.io/guides/accounts/capabilities/reference/).

The `transfers` capability is automatically requested for every account. If you request any capability beyond `transfers` (for example, `send-funds.ach`, `collect-funds.card-payments`), you'll need to:
  + Send Moov the user's [platform terms of service agreement](https://docs.moov.io/guides/accounts/requirements/platform-agreement/) acceptance. This can be done at account creation, or by [patching](https://docs.moov.io/api/moov-accounts/accounts/patch/) the account using the `termsOfService` field.
  + Fulfill the [verification and underwriting requirements](https://docs.moov.io/guides/accounts/requirements/) for each requested capability. A capability isn't enabled until its requirements pass — check the capability's status to see what's still outstanding.

If you're creating a business account, depending on the business type, you'll also need to:
  + Provide [business representatives](https://docs.moov.io/api/moov-accounts/representatives/) after creating the account.
  + [Patch](https://docs.moov.io/api/moov-accounts/accounts/patch/) the account to indicate that business representative ownership information is complete.

Visit our documentation to read more about [creating accounts](https://docs.moov.io/guides/accounts/create-accounts/) and [verification requirements](https://docs.moov.io/guides/accounts/requirements/identity-verification/). Note that the `mode` field (for production or sandbox) is only required when creating a Partner account. All other account requests will ignore the mode field and be set to the calling Partner account's mode.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need to specify the `/accounts.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccount" method="post" path="/accounts" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

CreateAccount req = new CreateAccount() {
    AccountType = CreateAccountType.Business,
    Profile = new CreateProfile() {
        Business = new CreateBusinessProfile() {
            LegalBusinessName = "Whole Body Fitness LLC",
        },
    },
};

var res = await sdk.Accounts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [CreateAccount](../../Models/Components/CreateAccount.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[CreateAccountResponse](../../Models/Requests/CreateAccountResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError       | 400, 409                                  | application/json                          |
| Moov.Sdk.Models.Errors.CreateAccountError | 422                                       | application/json                          |
| Moov.Sdk.Models.Errors.APIException       | 4XX, 5XX                                  | \*/\*                                     |

## List

List or search accounts to which the caller is connected.

All supported query parameters are optional. If none are provided the response will include all connected accounts.
Pagination is supported via the `skip` and `count` query parameters. Searching by name and email will overlap and 
return results based on relevance. Accounts with AccountType `guest` will not be included in the response.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccounts" method="get" path="/accounts" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListAccountsRequest req = new ListAccountsRequest() {
    Skip = 60,
    Count = 20,
};

var res = await sdk.Accounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListAccountsRequest](../../Models/Requests/ListAccountsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListAccountsResponse](../../Models/Requests/ListAccountsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Retrieves details for the account with the specified ID.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccount" method="get" path="/accounts/{accountID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Accounts.GetAsync(accountID: "2f93a6cf-3b3b-4c17-8d3b-110dfadccea4");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetAccountResponse](../../Models/Requests/GetAccountResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

When **can** profile data be updated:
  + For unverified accounts, all profile data can be edited.
  + During the verification process, missing or incomplete profile data can be edited.
  + Verified accounts can only add missing profile data.

  When **can't** profile data be updated:
  + Verified accounts cannot change any existing profile data.

If you need to update information in a locked state, please contact Moov support.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need
to specify the `/accounts/{accountID}/profile.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAccount" method="patch" path="/accounts/{accountID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Accounts.UpdateAsync(
    accountID: "433cb9d1-5943-4fd5-91b4-2aef5b30e2e7",
    body: new PatchAccount() {
        Profile = new PatchProfile() {
            Individual = new PatchIndividual() {
                Name = new IndividualNameUpdate() {
                    FirstName = "Jordan",
                    MiddleName = "Reese",
                    LastName = "Lee",
                    Suffix = "Jr",
                },
                Phone = new PhoneNumber() {
                    Number = "8185551212",
                    CountryCode = "1",
                },
                Email = "jordan.lee@classbooker.dev",
                Address = new AddressUpdate() {
                    AddressLine1 = "123 Main Street",
                    AddressLine2 = "Apt 302",
                    City = "Boulder",
                    StateOrProvince = "CO",
                    PostalCode = "80301",
                    Country = "US",
                },
                BirthDate = new BirthDateUpdate() {
                    Day = 9,
                    Month = 11,
                    Year = 1989,
                },
            },
            Business = new PatchBusiness() {
                BusinessType = BusinessType.Llc,
                Address = new AddressUpdate() {
                    AddressLine1 = "123 Main Street",
                    AddressLine2 = "Apt 302",
                    City = "Boulder",
                    StateOrProvince = "CO",
                    PostalCode = "80301",
                    Country = "US",
                },
                Phone = new PhoneNumber() {
                    Number = "8185551212",
                    CountryCode = "1",
                },
                Email = "jordan.lee@classbooker.dev",
                TaxID = new TaxIDUpdate() {
                    Ein = new TaxIDUpdateEin() {
                        Number = "12-3456789",
                    },
                },
                IndustryCodes = new IndustryCodes() {
                    Naics = "713940",
                    Sic = "7991",
                    Mcc = "7997",
                },
                Industry = "electronics-appliances",
            },
        },
        Metadata = new Dictionary<string, string>() {
            { "optional", "metadata" },
        },
        TermsOfService = new TermsOfServicePayloadUpdate() {
            Manual = new ManualTermsOfServiceUpdate() {
                AcceptedIP = "172.217.2.46",
                AcceptedUserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.71 Safari/537.36",
            },
        },
        CustomerSupport = new PatchAccountCustomerSupport() {
            Phone = new PhoneNumber() {
                Number = "8185551212",
                CountryCode = "1",
            },
            Email = "jordan.lee@classbooker.dev",
            Address = new AddressUpdate() {
                AddressLine1 = "123 Main Street",
                AddressLine2 = "Apt 302",
                City = "Boulder",
                StateOrProvince = "CO",
                PostalCode = "80301",
                Country = "US",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `AccountID`                                             | *string*                                                | :heavy_check_mark:                                      | N/A                                                     |
| `Body`                                                  | [PatchAccount](../../Models/Components/PatchAccount.md) | :heavy_check_mark:                                      | N/A                                                     |

### Response

**[UpdateAccountResponse](../../Models/Requests/UpdateAccountResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError      | 400, 409                                 | application/json                         |
| Moov.Sdk.Models.Errors.PatchAccountError | 422                                      | application/json                         |
| Moov.Sdk.Models.Errors.APIException      | 4XX, 5XX                                 | \*/\*                                    |

## Disconnect

This will sever the connection between you and the account specified and it will no longer be listed as 
active in the list of accounts. This also means you'll only have read-only access to the account going 
forward for reporting purposes.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.disconnect` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="disconnectAccount" method="delete" path="/accounts/{accountID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Accounts.DisconnectAsync(accountID: "cfdfea7d-f185-4de5-ba90-b09f14fe6683");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[DisconnectAccountResponse](../../Models/Requests/DisconnectAccountResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409                            | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## ListConnected

List or search accounts to which the caller is connected.

All supported query parameters are optional. If none are provided the response will include all connected accounts.
Pagination is supported via the `skip` and `count` query parameters. Searching by name and email will overlap and 
return results based on relevance. Accounts with AccountType `guest` will not be included in the response.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listConnectedAccountsForAccount" method="get" path="/accounts/{accountID}/connected-accounts" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListConnectedAccountsForAccountRequest req = new ListConnectedAccountsForAccountRequest() {
    AccountID = "7e09ffc8-e508-4fd4-a54e-21cff90a1824",
    Skip = 60,
    Count = 20,
};

var res = await sdk.Accounts.ListConnectedAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ListConnectedAccountsForAccountRequest](../../Models/Requests/ListConnectedAccountsForAccountRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[ListConnectedAccountsForAccountResponse](../../Models/Requests/ListConnectedAccountsForAccountResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Connect

Shares access scopes from the account specified to the caller, establishing a connection 
between the two accounts with the specified permissions.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="connectAccount" method="post" path="/accounts/{accountID}/connections" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Accounts.ConnectAsync(
    accountID: "456cb5b6-20dc-4585-97b4-745d013adb1f",
    body: new ShareScopes() {
        PrincipalAccountID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
        AllowScopes = new List<ApplicationScope>() {
            ApplicationScope.TransfersWrite,
            ApplicationScope.PaymentMethodsRead,
        },
    }
);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `AccountID`                                           | *string*                                              | :heavy_check_mark:                                    | N/A                                                   |
| `Body`                                                | [ShareScopes](../../Models/Components/ShareScopes.md) | :heavy_check_mark:                                    | N/A                                                   |

### Response

**[ConnectAccountResponse](../../Models/Requests/ConnectAccountResponse.md)**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                         | 400, 409                                                    | application/json                                            |
| Moov.Sdk.Models.Errors.ConnectAccountRequestValidationError | 422                                                         | application/json                                            |
| Moov.Sdk.Models.Errors.APIException                         | 4XX, 5XX                                                    | \*/\*                                                       |

## GetCountries

Retrieve the specified countries of operation for an account. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountCountries" method="get" path="/accounts/{accountID}/countries" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Accounts.GetCountriesAsync(accountID: "a2026036-cc26-42c1-beef-950662d13b5d");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetAccountCountriesResponse](../../Models/Requests/GetAccountCountriesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## AssignCountries

Assign the countries of operation for an account.

This endpoint will always overwrite the previously assigned values. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="assignAccountCountries" method="put" path="/accounts/{accountID}/countries" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Accounts.AssignCountriesAsync(
    accountID: "46736fa8-4bf7-4144-8e0e-dbea1eb0805b",
    body: new AccountCountries() {
        Countries = new List<string>() {
            "United States",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `AccountID`                                                     | *string*                                                        | :heavy_check_mark:                                              | N/A                                                             |
| `Body`                                                          | [AccountCountries](../../Models/Components/AccountCountries.md) | :heavy_check_mark:                                              | N/A                                                             |

### Response

**[AssignAccountCountriesResponse](../../Models/Requests/AssignAccountCountriesResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError         | 400, 409                                    | application/json                            |
| Moov.Sdk.Models.Errors.AssignCountriesError | 422                                         | application/json                            |
| Moov.Sdk.Models.Errors.APIException         | 4XX, 5XX                                    | \*/\*                                       |

## GetMerchantProcessingAgreement

Retrieve a merchant account's processing agreement.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMerchantProcessingAgreement" method="get" path="/accounts/{accountID}/merchant-agreement" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Accounts.GetMerchantProcessingAgreementAsync(accountID: "6180d9b9-2377-4190-8530-70a99d31a578");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetMerchantProcessingAgreementResponse](../../Models/Requests/GetMerchantProcessingAgreementResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetTermsOfServiceToken

Generates a non-expiring token that can then be used to accept Moov's terms of service. 

This token can only be generated via API. Any Moov account requesting the collect funds, send funds, wallet, 
or card issuing capabilities must accept Moov's terms of service, then have the generated terms of service 
token patched to the account. Read more in our [documentation](https://docs.moov.io/guides/accounts/requirements/platform-agreement/).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTermsOfServiceToken" method="get" path="/tos-token" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Accounts.GetTermsOfServiceTokenAsync();

// handle response
```

### Parameters

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `Origin`                                                                                                       | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | Indicates the domain from which the request originated. Required if referer header is not present.             |
| `Referer`                                                                                                      | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | Specifies the URL of the resource from which the request originated. Required if origin header is not present. |

### Response

**[GetTermsOfServiceTokenResponse](../../Models/Requests/GetTermsOfServiceTokenResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |