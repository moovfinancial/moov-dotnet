# BillingSummaryDetails

Details of volume and fees for a specific payment method.


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `VolumeAmount`                                            | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_minus_sign:                                        | The total transaction volume amount.                      |
| `VolumeCount`                                             | *long*                                                    | :heavy_minus_sign:                                        | The total number of transactions.                         |
| `FeeAmount`                                               | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_minus_sign:                                        | The total fee amount.                                     |