# ListSchedulesRequest


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            | Example                                                |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `Skip`                                                 | *long*                                                 | :heavy_minus_sign:                                     | N/A                                                    | 60                                                     |
| `Count`                                                | *long*                                                 | :heavy_minus_sign:                                     | Page size. When omitted, the server defaults to `200`. | 20                                                     |
| `Hydrate`                                              | [Hydrate](../../Models/Requests/Hydrate.md)            | :heavy_minus_sign:                                     | N/A                                                    |                                                        |
| `AccountID`                                            | *string*                                               | :heavy_check_mark:                                     | N/A                                                    |                                                        |