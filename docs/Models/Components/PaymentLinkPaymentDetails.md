# PaymentLinkPaymentDetails

Options for payment links used to collect payment.


## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `AllowedMethods`                                                                            | List<[CollectionPaymentMethodType](../../Models/Components/CollectionPaymentMethodType.md)> | :heavy_check_mark:                                                                          | A list of payment methods that should be supported for this payment link.                   |
| `CardDetails`                                                                               | [CardPaymentDetails](../../Models/Components/CardPaymentDetails.md)                         | :heavy_minus_sign:                                                                          | Options for payment links used to collect a card payment.                                   |
| `AchDetails`                                                                                | [ACHPaymentDetails](../../Models/Components/ACHPaymentDetails.md)                           | :heavy_minus_sign:                                                                          | Options for payment links used to collect an ACH payment.                                   |
| `Metadata`                                                                                  | Dictionary<String, *string*>                                                                | :heavy_minus_sign:                                                                          | Optional free-form metadata for the transfer.                                               |