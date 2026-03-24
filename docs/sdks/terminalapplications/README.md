# TerminalApplications

## Overview

### Available Operations

* [Create](#create) - Create a new terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.
* [List](#list) - List all the terminal applications for a Moov Account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.read` scope.
* [Get](#get) - Fetch a specific terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.read` scope.
* [Delete](#delete) - Delete a specific terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.
* [CreateVersion](#createversion) - Register a new version of a terminal application. For Android applications, this is used to register a new version code of the application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.

## Create

Create a new terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTerminalApplication" method="post" path="/terminal-applications" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

CreateTerminalApplication req = new CreateTerminalApplication() {
    Platform = TerminalApplicationPlatform.Android,
    PackageName = "com.example.app",
    Sha256Digest = "AA:BB:CC:DD:EE:FF:AA:BB:CC:DD:EE:FF:AA:BB:CC:DD:AA:BB:CC:DD:EE:FF:AA:BB:CC:DD:EE:FF:AA:BB:CC:DD",
    VersionCode = "20332277",
};

var res = await sdk.TerminalApplications.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CreateTerminalApplication](../../Models/Components/CreateTerminalApplication.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CreateTerminalApplicationResponse](../../Models/Requests/CreateTerminalApplicationResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError             | 400, 409                                        | application/json                                |
| Moov.Sdk.Models.Errors.TerminalApplicationError | 422                                             | application/json                                |
| Moov.Sdk.Models.Errors.APIException             | 4XX, 5XX                                        | \*/\*                                           |

## List

List all the terminal applications for a Moov Account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTerminalApplications" method="get" path="/terminal-applications" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TerminalApplications.ListAsync();

// handle response
```

### Response

**[ListTerminalApplicationsResponse](../../Models/Requests/ListTerminalApplicationsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Fetch a specific terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTerminalApplication" method="get" path="/terminal-applications/{terminalApplicationID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TerminalApplications.GetAsync(terminalApplicationID: "12345678-1234-1234-1234-123456789012");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `TerminalApplicationID`              | *string*                             | :heavy_check_mark:                   | N/A                                  | 12345678-1234-1234-1234-123456789012 |

### Response

**[GetTerminalApplicationResponse](../../Models/Requests/GetTerminalApplicationResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Delete

Delete a specific terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteTerminalApplication" method="delete" path="/terminal-applications/{terminalApplicationID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TerminalApplications.DeleteAsync(terminalApplicationID: "12345678-1234-1234-1234-123456789012");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `TerminalApplicationID`              | *string*                             | :heavy_check_mark:                   | N/A                                  | 12345678-1234-1234-1234-123456789012 |

### Response

**[DeleteTerminalApplicationResponse](../../Models/Requests/DeleteTerminalApplicationResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409                            | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## CreateVersion

Register a new version of a terminal application. For Android applications, this is used to register a new version code of the application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTerminalApplicationVersion" method="post" path="/terminal-applications/{terminalApplicationID}/versions" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.TerminalApplications.CreateVersionAsync(
    terminalApplicationID: "12345678-1234-1234-1234-123456789012",
    body: new TerminalApplicationVersion() {
        Version = "20440059",
    }
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         | Example                                                                             |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `TerminalApplicationID`                                                             | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 | 12345678-1234-1234-1234-123456789012                                                |
| `Body`                                                                              | [TerminalApplicationVersion](../../Models/Components/TerminalApplicationVersion.md) | :heavy_check_mark:                                                                  | N/A                                                                                 | {<br/>"version": "20440059"<br/>}                                                   |

### Response

**[CreateTerminalApplicationVersionResponse](../../Models/Requests/CreateTerminalApplicationVersionResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError             | 400, 409                                        | application/json                                |
| Moov.Sdk.Models.Errors.TerminalApplicationError | 422                                             | application/json                                |
| Moov.Sdk.Models.Errors.APIException             | 4XX, 5XX                                        | \*/\*                                           |