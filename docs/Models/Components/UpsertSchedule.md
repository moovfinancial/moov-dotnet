# UpsertSchedule


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `Description`                                             | *string*                                                  | :heavy_minus_sign:                                        | Simple description of what the schedule is.               |
| `Occurrences`                                             | List<[Occurrence](../../Models/Components/Occurrence.md)> | :heavy_minus_sign:                                        | N/A                                                       |
| `Recur`                                                   | [Recur](../../Models/Components/Recur.md)                 | :heavy_minus_sign:                                        | Defines configuration for recurring transfers.            |