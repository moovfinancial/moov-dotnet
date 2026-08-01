# InstantBankCreditTransferProcessingDetails


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Network`                                                                   | [InstantBankNetwork](../../Models/Components/InstantBankNetwork.md)         | :heavy_check_mark:                                                          | The network that the transaction was processed on.                          |
| `NetworkResponseCode`                                                       | *string*                                                                    | :heavy_minus_sign:                                                          | N/A                                                                         |
| `FailureCode`                                                               | [InstantBankFailureCode](../../Models/Components/InstantBankFailureCode.md) | :heavy_minus_sign:                                                          | Status codes for instant-bank failures.                                     |
| `EndToEndID`                                                                | *string*                                                                    | :heavy_minus_sign:                                                          | N/A                                                                         |