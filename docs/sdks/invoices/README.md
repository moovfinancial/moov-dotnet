# Invoices

## Overview

### Available Operations

* [CreateInvoice](#createinvoice) - Create an invoice for a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.
* [ListInvoices](#listinvoices) - List all the invoices created under a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.read` scope.
* [GetInvoice](#getinvoice) - Retrieve an invoice by ID.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.read` scope.
* [UpdateInvoice](#updateinvoice) - Updates an invoice.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.
* [Delete](#delete) - Delete an invoice. Only invoices in `draft` status can be deleted.

Deleting an invoice indicates it was created by mistake and should be completely disregarded.
Deleted invoices are hidden from list results by default, but can still be retrieved
individually through the get invoice endpoint. If you need to void an invoice that was
already sent or is otherwise part of the invoice history, cancel it instead by updating
its status to `canceled`.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.
* [CreateInvoicePayment](#createinvoicepayment) - Creates a payment resource to represent that an invoice was paid outside of the Moov platform.
If a payment link was created for the invoice, the corresponding payment link is canceled, but a receipt is still sent.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.
* [ListInvoicePayments](#listinvoicepayments) - List all the payments made towards an invoice.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.read` scope.

## CreateInvoice

Create an invoice for a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createInvoice" method="post" path="/accounts/{accountID}/invoices" example="Created invoice" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Invoices.CreateInvoiceAsync(
    accountID: "c463fb80-6410-48b7-9e2e-6e9ec58a654f",
    body: new CreateInvoice() {
        CustomerAccountID = "3dfff852-927d-47e8-822c-2fffc57ff6b9",
        Description = "Professional services for Q1 2026",
        LineItems = new CreateInvoiceLineItems() {
            Items = new List<CreateInvoiceLineItem>() {
                new CreateInvoiceLineItem() {
                    Name = "Professional Services",
                    BasePrice = new AmountDecimal() {
                        Currency = "USD",
                        ValueDecimal = "1000.00",
                    },
                    Quantity = 1,
                },
            },
        },
        InvoiceDate = System.DateTime.Parse("2026-01-15T00:00:00Z").ToUniversalTime(),
        DueDate = System.DateTime.Parse("2026-02-15T00:00:00Z").ToUniversalTime(),
    }
);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `AccountID`                                               | *string*                                                  | :heavy_check_mark:                                        | N/A                                                       |
| `Body`                                                    | [CreateInvoice](../../Models/Components/CreateInvoice.md) | :heavy_check_mark:                                        | N/A                                                       |

### Response

**[CreateInvoiceResponse](../../Models/Requests/CreateInvoiceResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError       | 400, 409                                  | application/json                          |
| Moov.Sdk.Models.Errors.CreateInvoiceError | 422                                       | application/json                          |
| Moov.Sdk.Models.Errors.APIException       | 4XX, 5XX                                  | \*/\*                                     |

## ListInvoices

List all the invoices created under a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listInvoices" method="get" path="/accounts/{accountID}/invoices" example="Invoices" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

ListInvoicesRequest req = new ListInvoicesRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "114b02db-e4ca-47de-acc9-5624f4afccb5",
};

var res = await sdk.Invoices.ListInvoicesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListInvoicesRequest](../../Models/Requests/ListInvoicesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListInvoicesResponse](../../Models/Requests/ListInvoicesResponse.md)**

### Errors

| Error Type                                         | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| Moov.Sdk.Models.Errors.ListInvoicesValidationError | 422                                                | application/json                                   |
| Moov.Sdk.Models.Errors.APIException                | 4XX, 5XX                                           | \*/\*                                              |

## GetInvoice

Retrieve an invoice by ID.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getInvoice" method="get" path="/accounts/{accountID}/invoices/{invoiceID}" example="Invoice" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Invoices.GetInvoiceAsync(
    accountID: "3ecce96f-a052-4c96-b389-98e880af1ab4",
    invoiceID: "fc90d016-39ea-4110-b77a-2e1c95827f46"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |
| `InvoiceID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetInvoiceResponse](../../Models/Requests/GetInvoiceResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## UpdateInvoice

Updates an invoice.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateInvoice" method="patch" path="/accounts/{accountID}/invoices/{invoiceID}" example="Updated invoice" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Invoices.UpdateInvoiceAsync(
    accountID: "fcce46d6-5a85-404a-afa3-f7303401bd08",
    invoiceID: "3eef5109-9937-40a3-b507-d5bc81fc02a2",
    body: new UpdateInvoice() {
        Description = "Updated professional services for Q1 2026",
        LineItems = new CreateInvoiceLineItemsUpdate() {
            Items = new List<CreateInvoiceLineItem>() {
                new CreateInvoiceLineItem() {
                    Name = "Professional Services",
                    BasePrice = new AmountDecimal() {
                        Currency = "USD",
                        ValueDecimal = "1000.00",
                    },
                    Quantity = 1,
                },
            },
        },
        InvoiceDate = System.DateTime.Parse("2026-01-16T00:00:00Z").ToUniversalTime(),
        DueDate = System.DateTime.Parse("2026-02-16T00:00:00Z").ToUniversalTime(),
    }
);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `AccountID`                                               | *string*                                                  | :heavy_check_mark:                                        | N/A                                                       |
| `InvoiceID`                                               | *string*                                                  | :heavy_check_mark:                                        | N/A                                                       |
| `Body`                                                    | [UpdateInvoice](../../Models/Components/UpdateInvoice.md) | :heavy_check_mark:                                        | N/A                                                       |

### Response

**[UpdateInvoiceResponse](../../Models/Requests/UpdateInvoiceResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError       | 400, 409                                  | application/json                          |
| Moov.Sdk.Models.Errors.UpdateInvoiceError | 422                                       | application/json                          |
| Moov.Sdk.Models.Errors.APIException       | 4XX, 5XX                                  | \*/\*                                     |

## Delete

Delete an invoice. Only invoices in `draft` status can be deleted.

Deleting an invoice indicates it was created by mistake and should be completely disregarded.
Deleted invoices are hidden from list results by default, but can still be retrieved
individually through the get invoice endpoint. If you need to void an invoice that was
already sent or is otherwise part of the invoice history, cancel it instead by updating
its status to `canceled`.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteInvoice" method="delete" path="/accounts/{accountID}/invoices/{invoiceID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Invoices.DeleteAsync(
    accountID: "<id>",
    invoiceID: "<id>"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |
| `InvoiceID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[DeleteInvoiceResponse](../../Models/Requests/DeleteInvoiceResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409                            | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## CreateInvoicePayment

Creates a payment resource to represent that an invoice was paid outside of the Moov platform.
If a payment link was created for the invoice, the corresponding payment link is canceled, but a receipt is still sent.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createInvoicePayment" method="post" path="/accounts/{accountID}/invoices/{invoiceID}/payments" example="External payment" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Invoices.CreateInvoicePaymentAsync(
    accountID: "e02333e4-a835-46d1-8d02-9af7a405e65f",
    invoiceID: "99e7ebb0-9996-49b2-98f0-304c7332ece6",
    body: new CreateInvoicePayment() {
        ForeignID = "EXT-PAY-12345",
        Amount = new AmountDecimal() {
            Currency = "USD",
            ValueDecimal = "500.00",
        },
        Description = "Payment received via wire transfer",
        PaymentDate = System.DateTime.Parse("2026-01-20T14:45:00Z").ToUniversalTime(),
    }
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `AccountID`                                                             | *string*                                                                | :heavy_check_mark:                                                      | N/A                                                                     |
| `InvoiceID`                                                             | *string*                                                                | :heavy_check_mark:                                                      | N/A                                                                     |
| `Body`                                                                  | [CreateInvoicePayment](../../Models/Components/CreateInvoicePayment.md) | :heavy_check_mark:                                                      | N/A                                                                     |

### Response

**[CreateInvoicePaymentResponse](../../Models/Requests/CreateInvoicePaymentResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| Moov.Sdk.Models.Errors.GenericError              | 400, 409                                         | application/json                                 |
| Moov.Sdk.Models.Errors.CreateInvoicePaymentError | 422                                              | application/json                                 |
| Moov.Sdk.Models.Errors.APIException              | 4XX, 5XX                                         | \*/\*                                            |

## ListInvoicePayments

List all the payments made towards an invoice.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/invoices.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listInvoicePayments" method="get" path="/accounts/{accountID}/invoices/{invoiceID}/payments" example="Payments" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Invoices.ListInvoicePaymentsAsync(
    accountID: "dcfbb04d-465e-4dbc-ad14-420961d94d21",
    invoiceID: "d25d8b7f-bb29-420c-8185-4ed9df60ba13"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |
| `InvoiceID`        | *string*           | :heavy_check_mark: | N/A                |

### Response

**[ListInvoicePaymentsResponse](../../Models/Requests/ListInvoicePaymentsResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |