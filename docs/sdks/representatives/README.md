# Representatives

## Overview

### Available Operations

* [Create](#create) - Moov accounts associated with businesses require information regarding individuals who represent the business. 
You can provide this information by creating a representative. Each account is allowed a maximum of 7 representatives. 
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.
* [List](#list) - A Moov account may have multiple representatives depending on the associated business's ownership and management structure. 
You can use this method to list all the representatives for a given Moov account. 
Note that Moov accounts associated with an individual do not have representatives. 
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.read` scope.
* [Delete](#delete) - Deletes a business representative associated with a Moov account. Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.
* [Get](#get) - Retrieve a specific representative associated with a given Moov account. Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.read` scope.
* [Update](#update) - If a representative's information has changed you can patch the information associated with a specific representative ID.
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

When **can** profile data be updated:

- For unverified representatives, all profile data can be edited.
- During the verification process, missing or incomplete profile data can be edited.
- Verified representatives can only add missing profile data.

When **can't** profile data be updated:

- Verified representatives cannot change any existing profile data.

If you need to update information in a locked state, please contact Moov support.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.

## Create

Moov accounts associated with businesses require information regarding individuals who represent the business. 
You can provide this information by creating a representative. Each account is allowed a maximum of 7 representatives. 
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepresentative" method="post" path="/accounts/{accountID}/representatives" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Representatives.CreateAsync(
    accountID: "5abfe3a5-7cd3-4f92-a8bd-19b64e3ccc10",
    body: new CreateRepresentative() {
        Name = new IndividualName() {
            FirstName = "Jordan",
            MiddleName = "Reese",
            LastName = "Lee",
            Suffix = "Jr",
        },
        Phone = new PhoneNumber() {
            Number = "8185551212",
            CountryCode = "1",
        },
        Email = "jordan.lee@classbooker.dev",
        Address = new Address() {
            AddressLine1 = "123 Main Street",
            AddressLine2 = "Apt 302",
            City = "Boulder",
            StateOrProvince = "CO",
            PostalCode = "80301",
            Country = "US",
        },
        BirthDate = new BirthDate() {
            Day = 9,
            Month = 11,
            Year = 1989,
        },
        Responsibilities = new RepresentativeResponsibilities() {
            OwnershipPercentage = 38,
            JobTitle = "CEO",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `AccountID`                                                             | *string*                                                                | :heavy_check_mark:                                                      | ID of the account.                                                      |
| `Body`                                                                  | [CreateRepresentative](../../Models/Components/CreateRepresentative.md) | :heavy_check_mark:                                                      | N/A                                                                     |

### Response

**[CreateRepresentativeResponse](../../Models/Requests/CreateRepresentativeResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| Moov.Sdk.Models.Errors.GenericError                  | 400, 409                                             | application/json                                     |
| Moov.Sdk.Models.Errors.RepresentativeValidationError | 422                                                  | application/json                                     |
| Moov.Sdk.Models.Errors.APIException                  | 4XX, 5XX                                             | \*/\*                                                |

## List

A Moov account may have multiple representatives depending on the associated business's ownership and management structure. 
You can use this method to list all the representatives for a given Moov account. 
Note that Moov accounts associated with an individual do not have representatives. 
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepresentatives" method="get" path="/accounts/{accountID}/representatives" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Representatives.ListAsync(accountID: "aa071158-7ed6-4c18-af34-4fa37b755e53");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | ID of the account. |

### Response

**[ListRepresentativesResponse](../../Models/Requests/ListRepresentativesResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Delete

Deletes a business representative associated with a Moov account. Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteRepresentative" method="delete" path="/accounts/{accountID}/representatives/{representativeID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Representatives.DeleteAsync(
    accountID: "23b950c7-3ccf-4edc-9566-07f765d57c73",
    representativeID: "74d0f56b-b81b-467a-bc86-47a55fe5e503"
);

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `AccountID`               | *string*                  | :heavy_check_mark:        | ID of the account.        |
| `RepresentativeID`        | *string*                  | :heavy_check_mark:        | ID of the representative. |

### Response

**[DeleteRepresentativeResponse](../../Models/Requests/DeleteRepresentativeResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409                            | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Get

Retrieve a specific representative associated with a given Moov account. Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepresentative" method="get" path="/accounts/{accountID}/representatives/{representativeID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Representatives.GetAsync(
    accountID: "071b8a57-e691-4e4b-9143-75f1a828ce9b",
    representativeID: "00d87070-b167-48e6-be2f-198b5e1556c4"
);

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `AccountID`               | *string*                  | :heavy_check_mark:        | ID of the account.        |
| `RepresentativeID`        | *string*                  | :heavy_check_mark:        | ID of the representative. |

### Response

**[GetRepresentativeResponse](../../Models/Requests/GetRepresentativeResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |

## Update

If a representative's information has changed you can patch the information associated with a specific representative ID.
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

When **can** profile data be updated:

- For unverified representatives, all profile data can be edited.
- During the verification process, missing or incomplete profile data can be edited.
- Verified representatives can only add missing profile data.

When **can't** profile data be updated:

- Verified representatives cannot change any existing profile data.

If you need to update information in a locked state, please contact Moov support.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepresentative" method="patch" path="/accounts/{accountID}/representatives/{representativeID}" -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Representatives.UpdateAsync(
    accountID: "76647e2b-97ea-4551-8275-7153219f3317",
    representativeID: "e89d3d0d-fbe3-4df6-8b18-d7cbcb761161",
    body: new UpdateRepresentative() {
        Name = new IndividualNameUpdate() {
            FirstName = "Jordan",
            MiddleName = "Reese",
            LastName = "Lee",
            Suffix = "Jr",
        },
        Phone = new Phone() {
            Number = "8185551212",
            CountryCode = "1",
        },
        Email = "jordan.lee@classbooker.dev",
        Address = new UpdateRepresentativeAddress() {
            AddressLine1 = "123 Main Street",
            AddressLine2 = "Apt 302",
            City = "Boulder",
            StateOrProvince = "CO",
            PostalCode = "80301",
            Country = "US",
        },
        BirthDate = null,
        Responsibilities = new Responsibilities() {
            OwnershipPercentage = 38,
            JobTitle = "CEO",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `AccountID`                                                             | *string*                                                                | :heavy_check_mark:                                                      | ID of the account.                                                      |
| `RepresentativeID`                                                      | *string*                                                                | :heavy_check_mark:                                                      | ID of the representative.                                               |
| `Body`                                                                  | [UpdateRepresentative](../../Models/Components/UpdateRepresentative.md) | :heavy_check_mark:                                                      | N/A                                                                     |

### Response

**[UpdateRepresentativeResponse](../../Models/Requests/UpdateRepresentativeResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Moov.Sdk.Models.Errors.GenericError | 400, 409                            | application/json                    |
| Moov.Sdk.Models.Errors.APIException | 4XX, 5XX                            | \*/\*                               |