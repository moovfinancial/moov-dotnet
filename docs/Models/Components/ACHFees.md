# ACHFees

A detailed breakdown of ACH fees.


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `StandardCredit`                                                          | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for standard credit transfers.                                       |
| `SameDayCredit`                                                           | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for same-day credit transfers.                                       |
| `Debits`                                                                  | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for debit transfers.                                                 |
| `Return`                                                                  | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for authorized returns.                                              |
| `UnauthorizedReturn`                                                      | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for unauthorized returns.                                            |
| `NoticeOfChange`                                                          | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Fees for notices of change.                                               |
| `Total`                                                                   | [BillingCountAndAmount](../../Models/Components/BillingCountAndAmount.md) | :heavy_check_mark:                                                        | Total ACH fees.                                                           |