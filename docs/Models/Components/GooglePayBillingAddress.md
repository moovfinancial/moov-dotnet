# GooglePayBillingAddress

  Billing address as returned by Google Pay.

  Refer to [Google's documentation](https://developers.google.com/pay/api/web/reference/response-objects#Address)
  for more information.


## Fields

| Field                                  | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `Address1`                             | *string*                               | :heavy_minus_sign:                     | First line of the street address.      |                                        |
| `Address2`                             | *string*                               | :heavy_minus_sign:                     | Second line of the street address.     |                                        |
| `Address3`                             | *string*                               | :heavy_minus_sign:                     | Third line of the street address.      |                                        |
| `Locality`                             | *string*                               | :heavy_minus_sign:                     | City, town, neighborhood, or suburb.   |                                        |
| `AdministrativeArea`                   | *string*                               | :heavy_minus_sign:                     | State, province, or region.            |                                        |
| `PostalCode`                           | *string*                               | :heavy_minus_sign:                     | Postal or ZIP code.                    |                                        |
| `CountryCode`                          | *string*                               | :heavy_minus_sign:                     | ISO 3166-1 alpha-2 country code.       | US                                     |
| `Name`                                 | *string*                               | :heavy_minus_sign:                     | Name of the cardholder.                |                                        |
| `PhoneNumber`                          | *string*                               | :heavy_minus_sign:                     | Phone number.                          |                                        |
| `SortingCode`                          | *string*                               | :heavy_minus_sign:                     | Sorting code (used in some countries). |                                        |