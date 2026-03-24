# Authentication

## Overview

### Available Operations

* [RevokeAccessToken](#revokeaccesstoken) - Revoke an auth token.

Allows clients to notify the authorization server that a previously obtained refresh or access token is no longer needed.
* [CreateAccessToken](#createaccesstoken) - Create or refresh an access token.

## RevokeAccessToken

Revoke an auth token.

Allows clients to notify the authorization server that a previously obtained refresh or access token is no longer needed.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="revokeAccessToken" method="post" path="/oauth2/revoke" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

RevokeTokenRequest req = new RevokeTokenRequest() {
    Token = "<value>",
    ClientId = "5clTR_MdVrrkgxw2",
    ClientSecret = "dNC-hg7sVm22jc3g_Eogtyu0_1Mqh_4-",
};

var res = await sdk.Authentication.RevokeAccessTokenAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [RevokeTokenRequest](../../Models/Components/RevokeTokenRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[RevokeAccessTokenResponse](../../Models/Requests/RevokeAccessTokenResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError            | 400                                            | application/json                               |
| Moov.Sdk.Models.Errors.RevokeTokenRequestError | 422                                            | application/json                               |
| Moov.Sdk.Models.Errors.APIException            | 4XX, 5XX                                       | \*/\*                                          |

## CreateAccessToken

Create or refresh an access token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccessToken" method="post" path="/oauth2/token" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

AuthTokenRequest req = new AuthTokenRequest() {
    GrantType = GrantType.ClientCredentials,
    ClientId = "5clTR_MdVrrkgxw2",
    ClientSecret = "dNC-hg7sVm22jc3g_Eogtyu0_1Mqh_4-",
    Scope = "/accounts.read /accounts.write",
    RefreshToken = "eyJhbGc0eSI6TQSIsImN0kpXVCIsImtp6IkpXVsImtpZC0a...",
};

var res = await sdk.Authentication.CreateAccessTokenAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [AuthTokenRequest](../../Models/Components/AuthTokenRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[CreateAccessTokenResponse](../../Models/Requests/CreateAccessTokenResponse.md)**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError          | 400                                          | application/json                             |
| Moov.Sdk.Models.Errors.AuthTokenRequestError | 422                                          | application/json                             |
| Moov.Sdk.Models.Errors.APIException          | 4XX, 5XX                                     | \*/\*                                        |