# LinkGooglePayError


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `Error`                                                                | *string*                                                               | :heavy_minus_sign:                                                     | Describes an error that wasn't attributable to a single request field. |
| `MerchantAccountID`                                                    | *string*                                                               | :heavy_minus_sign:                                                     | Describes an error within the `merchantAccountID` request field.       |
| `PaymentMethodData`                                                    | *string*                                                               | :heavy_minus_sign:                                                     | Describes an error within the `paymentMethodData` request field.       |
| `HttpMeta`                                                             | [HTTPMetadata](../../Models/Components/HTTPMetadata.md)                | :heavy_check_mark:                                                     | N/A                                                                    |