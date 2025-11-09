# BillingInterchangeProgramFee

Details of a specific interchange program fee.


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ProgramName`                                             | *string*                                                  | :heavy_check_mark:                                        | The name of the interchange program.                      |
| `Count`                                                   | *long*                                                    | :heavy_check_mark:                                        | The number of transactions for this program.              |
| `PercentageRate`                                          | *decimal*                                                 | :heavy_check_mark:                                        | The percentage rate for this program.                     |
| `PerItemRate`                                             | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | The per-item rate for this program.                       |
| `Total`                                                   | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | The total fee amount for this program.                    |
| `TransferVolume`                                          | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | The total transfer volume for this program.               |