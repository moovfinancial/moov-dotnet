# PlatformFees

A detailed breakdown of platform fees.


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `WalletFee`                                               | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | Fees associated with wallet services.                     |
| `MerchantPCIFee`                                          | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | Fees for PCI compliance.                                  |
| `Total`                                                   | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | Total platform fees.                                      |