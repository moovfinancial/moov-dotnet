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

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Scheduling.CreateAsync(
    accountID: "8b64fef5-c389-40d5-838f-d6ae10e70162",
    body: new UpsertSchedule() {
        Occurrences = new List<Occurrence>() {
            new Occurrence() {
                OccurrenceID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                RunOn = System.DateTime.Parse("2009-11-10T23:00:00Z").ToUniversalTime(),
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
            Start = System.DateTime.Parse("2009-11-10T23:00:00Z").ToUniversalTime(),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `AccountID`                                                 | *string*                                                    | :heavy_check_mark:                                          | Account ID of the account that will run the transfer.       |
| `Body`                                                      | [UpsertSchedule](../../Models/Components/UpsertSchedule.md) | :heavy_check_mark:                                          | N/A                                                         |

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
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Scheduling.ListAsync(
    accountID: "b69f6366-984e-40f9-82a0-65335a43431d",
    skip: 60,
    count: 20
);

// handle response
```

### Parameters

| Parameter                                   | Type                                        | Required                                    | Description                                 | Example                                     |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `AccountID`                                 | *string*                                    | :heavy_check_mark:                          | N/A                                         |                                             |
| `Skip`                                      | *long*                                      | :heavy_minus_sign:                          | N/A                                         | 60                                          |
| `Count`                                     | *long*                                      | :heavy_minus_sign:                          | N/A                                         | 20                                          |
| `Hydrate`                                   | [Hydrate](../../Models/Requests/Hydrate.md) | :heavy_minus_sign:                          | N/A                                         |                                             |

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

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Scheduling.UpdateAsync(
    accountID: "7becca38-ec01-4fcf-8cf7-c187c7cf6a7a",
    scheduleID: "11b29a8a-d60e-4ec9-900e-7fda62cd2415",
    body: new UpsertSchedule() {
        Occurrences = new List<Occurrence>() {
            new Occurrence() {
                OccurrenceID = "c520f1b9-0ba7-42f5-b977-248cdbe41c69",
                RunOn = System.DateTime.Parse("2009-11-10T23:00:00Z").ToUniversalTime(),
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
            Start = System.DateTime.Parse("2009-11-10T23:00:00Z").ToUniversalTime(),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `AccountID`                                                 | *string*                                                    | :heavy_check_mark:                                          | Account ID of the account that will run the transfer.       |
| `ScheduleID`                                                | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |
| `Body`                                                      | [UpsertSchedule](../../Models/Components/UpsertSchedule.md) | :heavy_check_mark:                                          | N/A                                                         |

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
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Scheduling.GetAsync(
    accountID: "31afd98b-eb55-41b3-8a4f-0ee8ea69e4e0",
    scheduleID: "55487e07-f3b7-44e8-b6f3-64fc85701c34"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | N/A                |
| `ScheduleID`       | *string*           | :heavy_check_mark: | N/A                |

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
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Scheduling.CancelAsync(
    accountID: "e89edcfc-19ca-40eb-802b-a35100dea24d",
    scheduleID: "5ca67de0-63f6-4cb7-b94a-6c84616ffe03"
);

// handle response
```

### Parameters

| Parameter                                                  | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `AccountID`                                                | *string*                                                   | :heavy_check_mark:                                         | Your Moov account ID as the partner running the transfers. |
| `ScheduleID`                                               | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |

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
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Scheduling.GetOccurranceAsync(
    accountID: "ea12b5d5-6249-4af2-ae48-6141a5251090",
    scheduleID: "289e94cd-66f1-4df5-999f-46d0f40b4ce9",
    occurrenceFilter: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                   | Type                                                                                                                                                                                                                                                                                        | Required                                                                                                                                                                                                                                                                                    | Description                                                                                                                                                                                                                                                                                 |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AccountID`                                                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                          | N/A                                                                                                                                                                                                                                                                                         |
| `ScheduleID`                                                                                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                          | N/A                                                                                                                                                                                                                                                                                         |
| `OccurrenceFilter`                                                                                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                          |   Allows the specification of additional filters beyond the string.<br/><br/>  Specifying a string returns the exact occurrence.<br/>  Specifying a RFC 3339 timestamp returns the latest occurrence at or before that timestamp.<br/>  Specifying `latest` returns the latest occurrence at or before now. |

### Response

**[GetScheduledOccurrenceResponse](../../Models/Requests/GetScheduledOccurrenceResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |