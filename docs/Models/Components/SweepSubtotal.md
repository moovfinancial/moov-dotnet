# SweepSubtotal


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Type`                                                                    | [WalletTransactionType](../../Models/Components/WalletTransactionType.md) | :heavy_check_mark:                                                        | The type of wallet transaction the subtotal is for.                       |
| `Count`                                                                   | *long*                                                                    | :heavy_check_mark:                                                        | The number of transactions of this type accrued in the sweep.             |
| `Amount`                                                                  | [AmountDecimal](../../Models/Components/AmountDecimal.md)                 | :heavy_check_mark:                                                        | The value of transactions of this type accrued in the sweep.              |