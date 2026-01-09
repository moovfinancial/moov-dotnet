# InvoicePayment

Payment made towards an invoice, will be either a transfer or an external payment.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `InvoicePaymentID`                                                          | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `InvoicePaymentType`                                                        | [InvoicePaymentType](../../Models/Components/InvoicePaymentType.md)         | :heavy_check_mark:                                                          | N/A                                                                         |
| `Transfer`                                                                  | [InvoiceTransferPayment](../../Models/Components/InvoiceTransferPayment.md) | :heavy_minus_sign:                                                          | N/A                                                                         |
| `External`                                                                  | [InvoiceExternalPayment](../../Models/Components/InvoiceExternalPayment.md) | :heavy_minus_sign:                                                          | N/A                                                                         |