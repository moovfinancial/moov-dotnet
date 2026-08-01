# CreateCaptureRequest


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `XIdempotencyKey`                                         | *string*                                                  | :heavy_check_mark:                                        | Prevents duplicate captures from being created.           |
| `AccountID`                                               | *string*                                                  | :heavy_check_mark:                                        | The merchant's Moov account ID.                           |
| `TransferID`                                              | *string*                                                  | :heavy_check_mark:                                        | Identifier for the transfer.                              |
| `Body`                                                    | [CreateCapture](../../Models/Components/CreateCapture.md) | :heavy_check_mark:                                        | N/A                                                       |