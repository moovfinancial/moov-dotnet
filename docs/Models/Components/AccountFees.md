# AccountFees

A detailed breakdown of account fees.


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `WalletFee`                                               | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | Fees associated with wallet services.                     |
| `MerchantPCIFee`                                          | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | Fees for PCI compliance.                                  |
| `InvoicePaymentFee`                                       | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | Fees for invoice payments.                                |
| `KybFee`                                                  | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_minus_sign:                                        | Fees for business verification.                           |
| `KycFee`                                                  | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_minus_sign:                                        | Fees for customer verification.                           |
| `TransactionMonitoringFee`                                | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_minus_sign:                                        | Fees for transaction risk monitoring.                     |
| `Total`                                                   | [AmountDecimal](../../Models/Components/AmountDecimal.md) | :heavy_check_mark:                                        | Total platform fees.                                      |