# AsyncCreatedRefund

Asynchronous refund response


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `RefundID`                                                                            | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `CreatedOn`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Amount`                                                                              | [AmountDecimal](../../Models/Components/AmountDecimal.md)                             | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `CaptureID`                                                                           | *string*                                                                              | :heavy_minus_sign:                                                                    | ID of the capture refunded for an auth-capture `card-payment` transfer.               |
| `AmountDetails`                                                                       | [RefundAmountDetails](../../Models/Components/RefundAmountDetails.md)                 | :heavy_minus_sign:                                                                    | N/A                                                                                   |