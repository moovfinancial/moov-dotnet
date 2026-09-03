# BillingAdjustment

An adjustment (correction) fee grouped by its statement line-item name.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `FeeName`                                                                | *string*                                                                 | :heavy_check_mark:                                                       | The name of the adjustment fee, shown as the statement line item.        |
| `Count`                                                                  | *long*                                                                   | :heavy_check_mark:                                                       | The number of adjustments with this fee name.                            |
| `Amount`                                                                 | [AmountDecimal](../../Models/Components/AmountDecimal.md)                | :heavy_check_mark:                                                       | The total amount for this fee name. May be negative for a credit/refund. |