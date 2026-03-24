# Onboarding

## Overview

### Available Operations

* [CreateInvite](#createinvite) - Create an invitation containing a unique link that allows the recipient to onboard their organization with Moov.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.
* [ListInvites](#listinvites) - List all the onboarding invites created by the caller's account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.read` scope.
* [GetInvite](#getinvite) - Retrieve details about an onboarding invite.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.read` scope.
* [RevokeInvite](#revokeinvite) - Revoke an onboarding invite, rendering the invitation link unusable.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.

## CreateInvite

Create an invitation containing a unique link that allows the recipient to onboard their organization with Moov.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createOnboardingInvite" method="post" path="/onboarding-invites" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

OnboardingInviteRequest req = new OnboardingInviteRequest() {
    Scopes = new List<ApplicationScope>() {
        ApplicationScope.AccountsRead,
    },
    GrantScopes = new List<ApplicationScope>() {
        ApplicationScope.TransfersWrite,
    },
    Capabilities = new List<CapabilityID>() {
        CapabilityID.Transfers,
    },
    FeePlanCodes = new List<string>() {
        "merchant-direct",
    },
    Prefill = new CreateAccount() {
        AccountType = AccountType.Business,
        Profile = new CreateProfile() {
            Business = new CreateBusinessProfile() {
                LegalBusinessName = "Whole Body Fitness LLC",
            },
        },
    },
};

var res = await sdk.Onboarding.CreateInviteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [OnboardingInviteRequest](../../Models/Components/OnboardingInviteRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[CreateOnboardingInviteResponse](../../Models/Requests/CreateOnboardingInviteResponse.md)**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError          | 400, 409                                     | application/json                             |
| Moov.Sdk.Models.Errors.OnboardingInviteError | 422                                          | application/json                             |
| Moov.Sdk.Models.Errors.APIException          | 4XX, 5XX                                     | \*/\*                                        |

## ListInvites

List all the onboarding invites created by the caller's account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listOnboardingInvites" method="get" path="/onboarding-invites" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Onboarding.ListInvitesAsync();

// handle response
```

### Response

**[ListOnboardingInvitesResponse](../../Models/Requests/ListOnboardingInvitesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetInvite

Retrieve details about an onboarding invite.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOnboardingInvite" method="get" path="/onboarding-invites/{code}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Onboarding.GetInviteAsync(code: "N1IA5eWYNh");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `Code`             | *string*           | :heavy_check_mark: | N/A                | N1IA5eWYNh         |

### Response

**[GetOnboardingInviteResponse](../../Models/Requests/GetOnboardingInviteResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## RevokeInvite

Revoke an onboarding invite, rendering the invitation link unusable.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="revokeOnboardingInvite" method="delete" path="/onboarding-invites/{code}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Onboarding.RevokeInviteAsync(code: "N1IA5eWYNh");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `Code`             | *string*           | :heavy_check_mark: | N/A                | N1IA5eWYNh         |

### Response

**[RevokeOnboardingInviteResponse](../../Models/Requests/RevokeOnboardingInviteResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |