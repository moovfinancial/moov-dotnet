# WireTransferProcessingDetails

Wire-specific processing details returned on a transfer.


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Status`                                                                  | [WireTransactionStatus](../../Models/Components/WireTransactionStatus.md) | :heavy_check_mark:                                                        | Status of a transaction within the wire lifecycle.                        |
| `NetworkResponseCode`                                                     | *string*                                                                  | :heavy_minus_sign:                                                        | Response code returned by the network on failure.                         |
| `FailureCode`                                                             | [WireFailureCode](../../Models/Components/WireFailureCode.md)             | :heavy_minus_sign:                                                        | Status codes for wire failures.                                           |