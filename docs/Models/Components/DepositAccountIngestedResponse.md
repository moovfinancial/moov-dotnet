# DepositAccountIngestedResponse

The result of ingesting a deposit account into the deposit view.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `MoovAccountID`                                                                       | *string*                                                                              | :heavy_check_mark:                                                                    | The Moov account that owns the deposit view the account was ingested into.            |
| `SourceSystem`                                                                        | [SourceSystem](../../Models/Components/SourceSystem.md)                               | :heavy_check_mark:                                                                    | The core banking source system that produced the ingested payload.                    |
| `SourceAccountID`                                                                     | *string*                                                                              | :heavy_check_mark:                                                                    | The identifier of the deposit account within the source system.                       |
| `IngestedAt`                                                                          | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | The date and time the deposit account was ingested.                                   |