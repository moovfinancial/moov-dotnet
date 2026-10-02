# CreateTransferDestination

The final stage of a transfer and the ultimate recipient of the funds.


## Fields

| Field                                                                                     | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `PaymentMethodID`                                                                         | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `CardDetails`                                                                             | [CreateTransferDestinationCard](../../Models/Components/CreateTransferDestinationCard.md) | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `AchDetails`                                                                              | [CreateTransferDestinationACH](../../Models/Components/CreateTransferDestinationACH.md)   | :heavy_minus_sign:                                                                        | N/A                                                                                       |