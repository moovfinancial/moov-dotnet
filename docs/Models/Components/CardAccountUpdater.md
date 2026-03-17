# CardAccountUpdater

The results of the most recent card update request.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `UpdatedOn`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Timestamp from the card network indicating when the card update was processed.        |                                                                                       |
| `UpdateType`                                                                          | [CardUpdateReason](../../Models/Components/CardUpdateReason.md)                       | :heavy_minus_sign:                                                                    | The results of the card update request.                                               | number-update                                                                         |