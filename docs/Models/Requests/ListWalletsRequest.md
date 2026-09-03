# ListWalletsRequest


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             | Example                                                 |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Status`                                                | [WalletStatus](../../Models/Components/WalletStatus.md) | :heavy_minus_sign:                                      | Optional parameter for filtering wallets by status.     |                                                         |
| `WalletType`                                            | [WalletType](../../Models/Components/WalletType.md)     | :heavy_minus_sign:                                      | Optional parameter for filtering wallets by type.       |                                                         |
| `Skip`                                                  | *long*                                                  | :heavy_minus_sign:                                      | N/A                                                     | 60                                                      |
| `Count`                                                 | *long*                                                  | :heavy_minus_sign:                                      | Page size. When omitted, the server defaults to `200`.  | 20                                                      |
| `AccountID`                                             | *string*                                                | :heavy_check_mark:                                      | N/A                                                     |                                                         |