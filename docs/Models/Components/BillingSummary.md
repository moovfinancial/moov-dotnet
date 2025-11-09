# BillingSummary

A summary of all fees included in a statement.


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `CardAcquiring`                                                           | [CardAcquiring](../../Models/Components/CardAcquiring.md)                 | :heavy_minus_sign:                                                        | A summary of card acquiring volume and fees.                              |
| `Ach`                                                                     | [BillingSummaryDetails](../../Models/Components/BillingSummaryDetails.md) | :heavy_minus_sign:                                                        | A summary of ACH volume and fees.                                         |
| `InstantPayments`                                                         | [BillingSummaryDetails](../../Models/Components/BillingSummaryDetails.md) | :heavy_minus_sign:                                                        | A summary of instant payment volume and fees.                             |
| `PlatformFees`                                                            | [AmountDecimal](../../Models/Components/AmountDecimal.md)                 | :heavy_minus_sign:                                                        | The total amount of platform fees.                                        |
| `AdjustmentFees`                                                          | [AmountDecimal](../../Models/Components/AmountDecimal.md)                 | :heavy_minus_sign:                                                        | The total amount of adjustment fees.                                      |
| `OtherFees`                                                               | [AmountDecimal](../../Models/Components/AmountDecimal.md)                 | :heavy_minus_sign:                                                        | The total amount of other fees.                                           |
| `Total`                                                                   | [AmountDecimal](../../Models/Components/AmountDecimal.md)                 | :heavy_minus_sign:                                                        | The total amount of all fees.                                             |