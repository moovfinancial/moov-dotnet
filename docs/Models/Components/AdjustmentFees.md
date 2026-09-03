# AdjustmentFees

A detailed breakdown of adjustment (correction) fees by fee name.


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Items`                                                                   | List<[BillingAdjustment](../../Models/Components/BillingAdjustment.md)>   | :heavy_check_mark:                                                        | Adjustment fees grouped by fee name.                                      |
| `Total`                                                                   | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Total adjustment fees.                                                    |