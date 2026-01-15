# Products

## Overview

### Available Operations

* [List](#list) - List active (non-disabled) products for an account.
* [Create](#create) - Creates a new product for the specified account.
* [Get](#get) - Retrieve a product by ID.
* [Update](#update) - Update a product and its options.
* [Disable](#disable) - Disable a product by ID.

The product will no longer be available, but will remain in the system for historical and reporting purposes.

## List

List active (non-disabled) products for an account.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listProducts" method="get" path="/accounts/{accountID}/products" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(xMoovVersion: "<value>");

ListProductsRequest req = new ListProductsRequest() {
    AccountID = "cd696219-4308-446c-b0d8-1759254995c2",
    Skip = 60,
    Count = 20,
};

var res = await sdk.Products.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListProductsRequest](../../Models/Requests/ListProductsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListProductsResponse](../../Models/Requests/ListProductsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Create

Creates a new product for the specified account.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createProduct" method="post" path="/accounts/{accountID}/products" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Products.CreateAsync(
    accountID: "27cd3181-7c1c-4d81-b020-e7d55c33941f",
    body: new ProductRequest() {
        Title = "World's best lemonade",
        Description = "Really, the best.",
        BasePrice = new AmountDecimal() {
            Currency = "USD",
            ValueDecimal = "4.99",
        },
        Images = new List<AssignProductImage>() {
            new AssignProductImage() {
                ImageID = "fed91252-6f48-4b70-885e-520bf53a52ff",
            },
            new AssignProductImage() {
                ImageID = "eb466644-0a58-4b87-af1e-94d03e223ad2",
            },
        },
        OptionGroups = new List<CreateProductOptionGroup>() {
            new CreateProductOptionGroup() {
                Name = "Flavor add-ins",
                Description = "Choose up to 3 flavor add-ins to enhance your lemonade.",
                MinSelect = 0,
                MaxSelect = 3,
                Options = new List<CreateProductOption>() {
                    new CreateProductOption() {
                        Name = "Strawberry puree",
                        Description = "Fresh and fruity.",
                        PriceModifier = new AmountDecimal() {
                            Currency = "USD",
                            ValueDecimal = "0.99",
                        },
                        Images = new List<AssignProductImage>() {
                            new AssignProductImage() {
                                ImageID = "d359808d-9896-4414-8d17-dac43f35842d",
                            },
                        },
                    },
                    new CreateProductOption() {
                        Name = "Passionfruit syrup",
                        PriceModifier = new AmountDecimal() {
                            Currency = "USD",
                            ValueDecimal = "0.49",
                        },
                    },
                    new CreateProductOption() {
                        Name = "Cherry syrup",
                        PriceModifier = new AmountDecimal() {
                            Currency = "USD",
                            ValueDecimal = "0.49",
                        },
                    },
                },
            },
            new CreateProductOptionGroup() {
                Name = "Sweetener",
                Description = "Choose a sweetener for your lemonade.",
                MinSelect = 1,
                MaxSelect = 1,
                Options = new List<CreateProductOption>() {
                    new CreateProductOption() {
                        Name = "Cane Sugar",
                    },
                    new CreateProductOption() {
                        Name = "Honey",
                        PriceModifier = new AmountDecimal() {
                            Currency = "USD",
                            ValueDecimal = "0.99",
                        },
                    },
                    new CreateProductOption() {
                        Name = "Stevia",
                        Description = "Natural, zero-calorie sweetener.",
                    },
                },
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | [ProductRequest](../../Models/Components/ProductRequest.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[CreateProductResponse](../../Models/Requests/CreateProductResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                  | 400, 409                                             | application/json                                     |
| Moov.Sdk.Models.Errors.ProductRequestValidationError | 422                                                  | application/json                                     |
| Moov.Sdk.Models.Errors.APIException                  | 4XX, 5XX                                             | \*/\*                                                |

## Get

Retrieve a product by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getProduct" method="get" path="/accounts/{accountID}/products/{productID}" -->
```csharp
using Moov.Sdk;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Products.GetAsync(
    accountID: "a749d848-5ebc-42a4-9ae6-555804317835",
    productID: "dd0b4873-5cf5-4aa8-aa86-e31d86f7e38a"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `ProductID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[GetProductResponse](../../Models/Requests/GetProductResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

Update a product and its options.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateProduct" method="put" path="/accounts/{accountID}/products/{productID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System.Collections.Generic;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Products.UpdateAsync(
    accountID: "7a7b55ed-d90d-4e83-a8f6-f146eaebd0cc",
    productID: "fa407877-3b46-4484-814e-65b147d76a9e",
    body: new ProductRequest() {
        Title = "<value>",
        BasePrice = new AmountDecimal() {
            Currency = "USD",
            ValueDecimal = "12.987654321",
        },
        OptionGroups = new List<CreateProductOptionGroup>() {
            new CreateProductOptionGroup() {
                Name = "<value>",
                MinSelect = 328576,
                MaxSelect = 430951,
                Options = new List<CreateProductOption>() {},
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `ProductID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | [ProductRequest](../../Models/Components/ProductRequest.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[UpdateProductResponse](../../Models/Requests/UpdateProductResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                  | 400, 409                                             | application/json                                     |
| Moov.Sdk.Models.Errors.ProductRequestValidationError | 422                                                  | application/json                                     |
| Moov.Sdk.Models.Errors.APIException                  | 4XX, 5XX                                             | \*/\*                                                |

## Disable

Disable a product by ID.

The product will no longer be available, but will remain in the system for historical and reporting purposes.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="disableProduct" method="delete" path="/accounts/{accountID}/products/{productID}" -->
```csharp
using Moov.Sdk;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Products.DisableAsync(
    accountID: "9fbe72c0-abba-4bb7-b1d0-d15ee702fe62",
    productID: "1e11a7dc-4e86-41ed-b256-55c22f3bfd38"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `ProductID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[DisableProductResponse](../../Models/Requests/DisableProductResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409                            | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |