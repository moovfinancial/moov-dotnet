# CardAcquiring

A summary of card acquiring volume and fees.


## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `VolumeAmount`                                                                    | [AmountDecimal](../../Models/Components/AmountDecimal.md)                         | :heavy_minus_sign:                                                                | The total transaction volume amount.                                              |
| `VolumeCount`                                                                     | *long*                                                                            | :heavy_minus_sign:                                                                | The total number of transactions.                                                 |
| `FeeAmount`                                                                       | [AmountDecimal](../../Models/Components/AmountDecimal.md)                         | :heavy_minus_sign:                                                                | The total fee amount.                                                             |
| `InterchangeFees`                                                                 | [BillingSummaryInterchange](../../Models/Components/BillingSummaryInterchange.md) | :heavy_minus_sign:                                                                | A summary of interchange fees by card brand.                                      |