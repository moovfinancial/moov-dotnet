# AccountTerminalApplications

## Overview

### Available Operations

* [Link](#link) - Link an account with a terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.write` scope.
* [List](#list) - Retrieve all terminal applications linked to a specific account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.read` scope.
* [Get](#get) - Verifies if a specific Terminal Application is linked to an Account. This endpoint acts as a validation check for the link's existence.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.read` scope.
* [GetConfiguration](#getconfiguration) - Fetch the configuration for a given Terminal Application linked to a specific Account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-configuration.read` scope.

## Link

Link an account with a terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="linkAccountTerminalApplication" method="post" path="/accounts/{accountID}/terminal-applications" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.AccountTerminalApplications.LinkAsync(
    accountID: "76d4c8a0-1f2b-4e3b-8f5c-7a9e1b2c3d4e",
    body: new LinkAccountTerminalApplication() {
        TerminalApplicationID = "12345678-1234-1234-1234-123456789012",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 | Example                                                                                     |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                 | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         | 76d4c8a0-1f2b-4e3b-8f5c-7a9e1b2c3d4e                                                        |
| `Body`                                                                                      | [LinkAccountTerminalApplication](../../Models/Components/LinkAccountTerminalApplication.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |                                                                                             |

### Response

**[LinkAccountTerminalApplicationResponse](../../Models/Requests/LinkAccountTerminalApplicationResponse.md)**

### Errors

| Error Type                                             | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| Moov.Sdk.Models.Errors.GenericError                    | 400, 409                                               | application/json                                       |
| Moov.Sdk.Models.Errors.AccountTerminalApplicationError | 422                                                    | application/json                                       |
| Moov.Sdk.Models.Errors.APIException                    | 4XX, 5XX                                               | \*/\*                                                  |

## List

Retrieve all terminal applications linked to a specific account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountTerminalApplications" method="get" path="/accounts/{accountID}/terminal-applications" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.AccountTerminalApplications.ListAsync(accountID: "76d4c8a0-1f2b-4e3b-8f5c-7a9e1b2c3d4e");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `AccountID`                          | *string*                             | :heavy_check_mark:                   | N/A                                  | 76d4c8a0-1f2b-4e3b-8f5c-7a9e1b2c3d4e |

### Response

**[ListAccountTerminalApplicationsResponse](../../Models/Requests/ListAccountTerminalApplicationsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Verifies if a specific Terminal Application is linked to an Account. This endpoint acts as a validation check for the link's existence.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountTerminalApplication" method="get" path="/accounts/{accountID}/terminal-applications/{terminalApplicationID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.AccountTerminalApplications.GetAsync(
    accountID: "76d4c8a0-1f2b-4e3b-8f5c-7a9e1b2c3d4e",
    terminalApplicationID: "12345678-1234-1234-1234-123456789012"
);

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `AccountID`                          | *string*                             | :heavy_check_mark:                   | N/A                                  | 76d4c8a0-1f2b-4e3b-8f5c-7a9e1b2c3d4e |
| `TerminalApplicationID`              | *string*                             | :heavy_check_mark:                   | N/A                                  | 12345678-1234-1234-1234-123456789012 |

### Response

**[GetAccountTerminalApplicationResponse](../../Models/Requests/GetAccountTerminalApplicationResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetConfiguration

Fetch the configuration for a given Terminal Application linked to a specific Account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-configuration.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTerminalConfiguration" method="get" path="/accounts/{accountID}/terminal-applications/{terminalApplicationID}/configuration" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.AccountTerminalApplications.GetConfigurationAsync(
    accountID: "76d4c8a0-1f2b-4e3b-8f5c-7a9e1b2c3d4e",
    terminalApplicationID: "12345678-1234-1234-1234-123456789012"
);

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `AccountID`                          | *string*                             | :heavy_check_mark:                   | N/A                                  | 76d4c8a0-1f2b-4e3b-8f5c-7a9e1b2c3d4e |
| `TerminalApplicationID`              | *string*                             | :heavy_check_mark:                   | N/A                                  | 12345678-1234-1234-1234-123456789012 |

### Response

**[GetTerminalConfigurationResponse](../../Models/Requests/GetTerminalConfigurationResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |