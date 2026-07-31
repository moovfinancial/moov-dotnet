# Avatars

## Overview

### Available Operations

* [Get](#get) - Get avatar image for an account using a unique ID.    

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/profile-enrichment.read` scope.

## Get

Get avatar image for an account using a unique ID.    

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/profile-enrichment.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAvatar" method="get" path="/avatars/{uniqueID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Avatars.GetAsync(uniqueID: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `UniqueID`                                                                                               | *string*                                                                                                 | :heavy_check_mark:                                                                                       | Any unique ID associated with an account such as accountID, representativeID, routing number, or userID. |

### Response

**[GetAvatarResponse](../../Models/Requests/GetAvatarResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |