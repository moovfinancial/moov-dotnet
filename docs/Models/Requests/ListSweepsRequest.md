# ListSweepsRequest


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `AccountID`                                           | *string*                                              | :heavy_check_mark:                                    | N/A                                                   |                                                       |
| `WalletID`                                            | *string*                                              | :heavy_check_mark:                                    | N/A                                                   |                                                       |
| `Skip`                                                | *long*                                                | :heavy_minus_sign:                                    | N/A                                                   | 60                                                    |
| `Count`                                               | *long*                                                | :heavy_minus_sign:                                    | N/A                                                   | 20                                                    |
| `Status`                                              | [SweepStatus](../../Models/Components/SweepStatus.md) | :heavy_minus_sign:                                    | Optional parameter to filter by sweep status.         |                                                       |
| `StatementDescriptor`                                 | *string*                                              | :heavy_minus_sign:                                    | Optional string to filter by statement descriptor.    |                                                       |