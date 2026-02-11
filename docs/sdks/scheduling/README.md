# Scheduling

## Overview

### Available Operations

* [Create](#create) - Describes the schedule to create or modify.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [List](#list) - Describes a list of schedules associated with an account. Append the `hydrate=accounts` query parameter to include partial account details in the response.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Update](#update) - Describes the schedule to modify.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [Get](#get) - Describes a schedule associated with an account. Requires at least 1 occurrence or recurTransfer to be specified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Cancel](#cancel) - Describes the schedule to cancel.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [GetOccurrance](#getoccurrance) - Gets a specific occurrence.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

## Create

Describes the schedule to create or modify.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSchedule" method="post" path="/accounts/{accountID}/schedules" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Scheduling.CreateAsync(
    accountID: "8b64fef5-c389-40d5-838f-d6ae10e70162",
    body: new UpsertSchedule() {
        Occurrences = new List<Occurrence>() {
            new Occurrence() {
                OccurrenceID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                RunOn = System.DateTime.Parse("2009-11-10T23:00:00Z"),
                RunTransfer = new CreateRunTransfer() {
                    Amount = new Amount() {
                        Currency = "USD",
                        Value = 1204,
                    },
                    Destination = new SchedulePaymentMethod() {
                        PaymentMethodID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                        AchDetails = new AchDetails() {
                            CompanyEntryDescription = "Gym dues",
                            OriginatingCompanyName = "Whole Body Fit",
                        },
                        CardDetails = new CardDetails() {
                            DynamicDescriptor = "WhlBdy *Yoga 11-12",
                        },
                    },
                    PartnerAccountID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                    Source = new SchedulePaymentMethod() {
                        PaymentMethodID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                        AchDetails = new AchDetails() {
                            CompanyEntryDescription = "Gym dues",
                            OriginatingCompanyName = "Whole Body Fit",
                        },
                        CardDetails = new CardDetails() {
                            DynamicDescriptor = "WhlBdy *Yoga 11-12",
                        },
                    },
                    Description = "er mob marathon lest optimistically responsible",
                },
            },
        },
        Recur = new Recur() {
            RecurrenceRule = "<value>",
            RunTransfer = new CreateRunTransfer() {
                Amount = new Amount() {
                    Currency = "USD",
                    Value = 1204,
                },
                SalesTaxAmount = new Amount() {
                    Currency = "USD",
                    Value = 1204,
                },
                Destination = new SchedulePaymentMethod() {
                    PaymentMethodID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                    AchDetails = new AchDetails() {
                        CompanyEntryDescription = "Gym dues",
                        OriginatingCompanyName = "Whole Body Fit",
                    },
                    CardDetails = new CardDetails() {
                        DynamicDescriptor = "WhlBdy *Yoga 11-12",
                    },
                },
                PartnerAccountID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                Source = new SchedulePaymentMethod() {
                    PaymentMethodID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                    AchDetails = new AchDetails() {
                        CompanyEntryDescription = "Gym dues",
                        OriginatingCompanyName = "Whole Body Fit",
                    },
                    CardDetails = new CardDetails() {
                        DynamicDescriptor = "WhlBdy *Yoga 11-12",
                    },
                },
                Description = "er mob marathon lest optimistically responsible",
                LineItems = new CreateScheduledTransferLineItems() {
                    Items = new List<CreateScheduledTransferLineItem>() {},
                },
            },
            Start = System.DateTime.Parse("2009-11-10T23:00:00Z"),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Account ID of the account that will run the transfer.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | [UpsertSchedule](../../Models/Components/UpsertSchedule.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[CreateScheduleResponse](../../Models/Requests/CreateScheduleResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError            | 400, 409                                       | application/json                               |
| Moov.Sdk.Models.Errors.ScheduleValidationError | 422                                            | application/json                               |
| Moov.Sdk.Models.Errors.APIException            | 4XX, 5XX                                       | \*/\*                                          |

## List

Describes a list of schedules associated with an account. Append the `hydrate=accounts` query parameter to include partial account details in the response.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSchedules" method="get" path="/accounts/{accountID}/schedules" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Requests;

var sdk = new MoovClient(xMoovVersion: "<value>");

ListSchedulesRequest req = new ListSchedulesRequest() {
    Skip = 60,
    Count = 20,
    AccountID = "b69f6366-984e-40f9-82a0-65335a43431d",
};

var res = await sdk.Scheduling.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListSchedulesRequest](../../Models/Requests/ListSchedulesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListSchedulesResponse](../../Models/Requests/ListSchedulesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

Describes the schedule to modify.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateSchedule" method="put" path="/accounts/{accountID}/schedules/{scheduleID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Scheduling.UpdateAsync(
    accountID: "7becca38-ec01-4fcf-8cf7-c187c7cf6a7a",
    scheduleID: "11b29a8a-d60e-4ec9-900e-7fda62cd2415",
    body: new UpsertSchedule() {
        Occurrences = new List<Occurrence>() {
            new Occurrence() {
                OccurrenceID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                RunOn = System.DateTime.Parse("2009-11-10T23:00:00Z"),
                RunTransfer = new CreateRunTransfer() {
                    Amount = new Amount() {
                        Currency = "USD",
                        Value = 1204,
                    },
                    Destination = new SchedulePaymentMethod() {
                        PaymentMethodID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                        AchDetails = new AchDetails() {
                            CompanyEntryDescription = "Gym dues",
                            OriginatingCompanyName = "Whole Body Fit",
                        },
                        CardDetails = new CardDetails() {
                            DynamicDescriptor = "WhlBdy *Yoga 11-12",
                        },
                    },
                    PartnerAccountID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                    Source = new SchedulePaymentMethod() {
                        PaymentMethodID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                        AchDetails = new AchDetails() {
                            CompanyEntryDescription = "Gym dues",
                            OriginatingCompanyName = "Whole Body Fit",
                        },
                        CardDetails = new CardDetails() {
                            DynamicDescriptor = "WhlBdy *Yoga 11-12",
                        },
                    },
                    Description = "yum who queasily bemuse ick dull almighty incidentally er despite",
                },
            },
        },
        Recur = new Recur() {
            RecurrenceRule = "<value>",
            RunTransfer = new CreateRunTransfer() {
                Amount = new Amount() {
                    Currency = "USD",
                    Value = 1204,
                },
                SalesTaxAmount = new Amount() {
                    Currency = "USD",
                    Value = 1204,
                },
                Destination = new SchedulePaymentMethod() {
                    PaymentMethodID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                    AchDetails = new AchDetails() {
                        CompanyEntryDescription = "Gym dues",
                        OriginatingCompanyName = "Whole Body Fit",
                    },
                    CardDetails = new CardDetails() {
                        DynamicDescriptor = "WhlBdy *Yoga 11-12",
                    },
                },
                PartnerAccountID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                Source = new SchedulePaymentMethod() {
                    PaymentMethodID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                    AchDetails = new AchDetails() {
                        CompanyEntryDescription = "Gym dues",
                        OriginatingCompanyName = "Whole Body Fit",
                    },
                    CardDetails = new CardDetails() {
                        DynamicDescriptor = "WhlBdy *Yoga 11-12",
                    },
                },
                Description = "yum who queasily bemuse ick dull almighty incidentally er despite",
                LineItems = new CreateScheduledTransferLineItems() {
                    Items = new List<CreateScheduledTransferLineItem>() {
                        new CreateScheduledTransferLineItem() {
                            Name = "<value>",
                            BasePrice = new AmountDecimal() {
                                Currency = "USD",
                                ValueDecimal = "12.987654321",
                            },
                            Quantity = 973458,
                            Options = new List<CreateScheduledTransferLineItemOption>() {
                                new CreateScheduledTransferLineItemOption() {
                                    Name = "<value>",
                                    Quantity = 221042,
                                    PriceModifier = new AmountDecimal() {
                                        Currency = "USD",
                                        ValueDecimal = "12.987654321",
                                    },
                                },
                            },
                        },
                    },
                },
            },
            Start = System.DateTime.Parse("2009-11-10T23:00:00Z"),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Account ID of the account that will run the transfer.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| `ScheduleID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `Body`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | [UpsertSchedule](../../Models/Components/UpsertSchedule.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[UpdateScheduleResponse](../../Models/Requests/UpdateScheduleResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError            | 400, 409                                       | application/json                               |
| Moov.Sdk.Models.Errors.ScheduleValidationError | 422                                            | application/json                               |
| Moov.Sdk.Models.Errors.APIException            | 4XX, 5XX                                       | \*/\*                                          |

## Get

Describes a schedule associated with an account. Requires at least 1 occurrence or recurTransfer to be specified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSchedules" method="get" path="/accounts/{accountID}/schedules/{scheduleID}" -->
```csharp
using Moov.Sdk;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Scheduling.GetAsync(
    accountID: "31afd98b-eb55-41b3-8a4f-0ee8ea69e4e0",
    scheduleID: "55487e07-f3b7-44e8-b6f3-64fc85701c34"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `ScheduleID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[GetSchedulesResponse](../../Models/Requests/GetSchedulesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Cancel

Describes the schedule to cancel.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelSchedule" method="delete" path="/accounts/{accountID}/schedules/{scheduleID}" -->
```csharp
using Moov.Sdk;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Scheduling.CancelAsync(
    accountID: "e89edcfc-19ca-40eb-802b-a35100dea24d",
    scheduleID: "5ca67de0-63f6-4cb7-b94a-6c84616ffe03"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Your Moov account ID as the partner running the transfers.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| `ScheduleID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[CancelScheduleResponse](../../Models/Requests/CancelScheduleResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409                            | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## GetOccurrance

Gets a specific occurrence.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getScheduledOccurrence" method="get" path="/accounts/{accountID}/schedules/{scheduleID}/occurrences/{occurrenceFilter}" -->
```csharp
using Moov.Sdk;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Scheduling.GetOccurranceAsync(
    accountID: "ea12b5d5-6249-4af2-ae48-6141a5251090",
    scheduleID: "289e94cd-66f1-4df5-999f-46d0f40b4ce9",
    occurrenceFilter: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `ScheduleID`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `OccurrenceFilter`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |   Allows the specification of additional filters beyond the UUID.<br/><br/>  Specifying a UUID string returns the exact occurrence.<br/>  Specifying a RFC 3339 timestamp returns the latest occurrence at or before that timestamp.<br/>  Specifying `latest` returns the latest occurrence at or before now.                                                                                                                                                                                                                                                                                     |
| `XMoovVersion`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Specify an API version.<br/><br/>API versioning follows the format `vYYYY.QQ.BB`, where <br/>  - `YYYY` is the year<br/>  - `QQ` is the two-digit month for the first month of the quarter (e.g., 01, 04, 07, 10)<br/>  - `BB` is the build number, starting at `.01`, for subsequent builds in the same quarter. <br/>    - For example, `v2024.01.00` is the initial release of the first quarter of 2024.<br/><br/>The `latest` version represents the most recent development state. It may include breaking changes and should be treated as a beta release.<br/>When no version is specified, the API defaults to `v2024.01.00`. |

### Response

**[GetScheduledOccurrenceResponse](../../Models/Requests/GetScheduledOccurrenceResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |