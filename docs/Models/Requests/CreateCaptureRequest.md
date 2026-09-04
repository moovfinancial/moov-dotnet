# CreateCaptureRequest


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `XIdempotencyKey`                                         | *string*                                                  | :heavy_check_mark:                                        | Prevents duplicate captures from being created.           |
| `AccountID`                                               | *string*                                                  | :heavy_check_mark:                                        | Moov account ID of the partner for the transfer.          |
| `TransferID`                                              | *string*                                                  | :heavy_check_mark:                                        | Identifier for the auth-capture `card-payment` transfer.  |
| `Body`                                                    | [CreateCapture](../../Models/Components/CreateCapture.md) | :heavy_check_mark:                                        | N/A                                                       |