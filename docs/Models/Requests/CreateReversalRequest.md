# CreateReversalRequest


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `XIdempotencyKey`                                           | *string*                                                    | :heavy_check_mark:                                          | Prevents duplicate reversals from being created.            |
| `AccountID`                                                 | *string*                                                    | :heavy_check_mark:                                          | The Moov account ID.                                        |
| `TransferID`                                                | *string*                                                    | :heavy_check_mark:                                          | The transfer ID to reverse.                                 |
| `Body`                                                      | [CreateReversal](../../Models/Components/CreateReversal.md) | :heavy_minus_sign:                                          | N/A                                                         |