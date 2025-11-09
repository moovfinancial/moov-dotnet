# OtherCardFees

A detailed breakdown of other card-related fees.


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Disputes`                                                                | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for disputes.                                                        |
| `CardAccountUpdater`                                                      | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for card account updater services.                                   |
| `CardVerification`                                                        | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for card verification.                                               |
| `NameVerification`                                                        | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for name verification.                                               |
| `Total`                                                                   | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Total other card fees.                                                    |