# Avatars

## Overview

### Available Operations

* [Get](#get) - Get avatar image for an account using a unique ID.    

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/profile-enrichment.read` scope.
* [Upload](#upload) - Upload a user avatar image for an account.

The image will be normalized to 512x512 PNG format and stored separately from 
automatically discovered logos. User-uploaded avatars take precedence over enriched avatars at read time.

This endpoint only accepts accountID values for the uniqueID parameter.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.
* [Delete](#delete) - Delete a user-uploaded avatar for an account.

After deletion, the avatar endpoint will fall back to the enriched avatar
or an account-type-aware fallback icon.

This endpoint only accepts accountID values for the uniqueID parameter.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.

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

## Upload

Upload a user avatar image for an account.

The image will be normalized to 512x512 PNG format and stored separately from 
automatically discovered logos. User-uploaded avatars take precedence over enriched avatars at read time.

This endpoint only accepts accountID values for the uniqueID parameter.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uploadAvatar" method="put" path="/avatars/{uniqueID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient();

var res = await sdk.Avatars.UploadAsync(
    security: new UploadAvatarSecurity() {
        BasicAuth = new SchemeBasicAuth() {
            Username = "",
            Password = "",
        },
    },
    uniqueID: "<id>",
    body: new AvatarUploadRequest() {
        File = new AvatarUploadRequestFile() {
            FileName = "example.file",
            Content = System.IO.File.ReadAllBytes("example.file"),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `security`                                                                             | [UploadAvatarSecurity](../../Models/Requests/UploadAvatarSecurity.md)                  | :heavy_check_mark:                                                                     | The security requirements to use for the request.                                      |
| `UniqueID`                                                                             | *string*                                                                               | :heavy_check_mark:                                                                     | The accountID to upload the avatar for. Only accountID values are accepted for writes. |
| `Body`                                                                                 | [AvatarUploadRequest](../../Models/Components/AvatarUploadRequest.md)                  | :heavy_check_mark:                                                                     | N/A                                                                                    |

### Response

**[UploadAvatarResponse](../../Models/Requests/UploadAvatarResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400                                 | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Delete

Delete a user-uploaded avatar for an account.

After deletion, the avatar endpoint will fall back to the enriched avatar
or an account-type-aware fallback icon.

This endpoint only accepts accountID values for the uniqueID parameter.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteAvatar" method="delete" path="/avatars/{uniqueID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient();

var res = await sdk.Avatars.DeleteAsync(
    security: new DeleteAvatarSecurity() {
        BasicAuth = new SchemeBasicAuth() {
            Username = "",
            Password = "",
        },
    },
    uniqueID: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `security`                                                                             | [DeleteAvatarSecurity](../../Models/Requests/DeleteAvatarSecurity.md)                  | :heavy_check_mark:                                                                     | The security requirements to use for the request.                                      |
| `UniqueID`                                                                             | *string*                                                                               | :heavy_check_mark:                                                                     | The accountID to delete the avatar for. Only accountID values are accepted for writes. |

### Response

**[DeleteAvatarResponse](../../Models/Requests/DeleteAvatarResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400                                 | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |