# Files

## Overview

### Available Operations

* [Upload](#upload) - Upload a file and link it to the specified Moov account. 

The maximum file size is 20MB. Each account is allowed a maximum of 50 files. Acceptable file types include csv, jpg, pdf, 
and png. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.write` scope.
* [List](#list) - List all the files associated with a particular Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.read` scope.
* [Get](#get) - Retrieve file details associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.read` scope.

## Upload

Upload a file and link it to the specified Moov account. 

The maximum file size is 20MB. Each account is allowed a maximum of 50 files. Acceptable file types include csv, jpg, pdf, 
and png. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uploadFile" method="post" path="/accounts/{accountID}/files" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Files.UploadAsync(
    accountID: "221c30bd-2551-4ae4-9a14-07bf6599b728",
    body: new FileUploadRequestMultiPart() {
        File = new FileUploadRequestMultiPartFile() {
            FileName = "example.file",
            Content = System.IO.File.ReadAllBytes("example.file"),
        },
        FilePurpose = FilePurpose.RepresentativeVerification,
    }
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `AccountID`                                                                         | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `Body`                                                                              | [FileUploadRequestMultiPart](../../Models/Components/FileUploadRequestMultiPart.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |

### Response

**[UploadFileResponse](../../Models/Requests/UploadFileResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Moov.Sdk.Models.Errors.GenericError        | 400, 409                                   | application/json                           |
| Moov.Sdk.Models.Errors.FileValidationError | 422                                        | application/json                           |
| Moov.Sdk.Models.Errors.APIException        | 4XX, 5XX                                   | \*/\*                                      |

## List

List all the files associated with a particular Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFiles" method="get" path="/accounts/{accountID}/files" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Files.ListAsync(accountID: "d1133bf2-4853-4436-9a03-23739895ab98");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[ListFilesResponse](../../Models/Requests/ListFilesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Retrieve file details associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFileDetails" method="get" path="/accounts/{accountID}/files/{fileID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Files.GetAsync(
    accountID: "7f888113-d35a-4536-b9bc-c55076736ab6",
    fileID: "af170db9-0d17-4a9f-ade6-5dd2f1b3412d"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |
| `FileID`           | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetFileDetailsResponse](../../Models/Requests/GetFileDetailsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |