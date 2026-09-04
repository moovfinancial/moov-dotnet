# ListTicketsRequest


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             | Example                                                 |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Cursor`                                                | *string*                                                | :heavy_minus_sign:                                      | N/A                                                     |                                                         |
| `Count`                                                 | *long*                                                  | :heavy_minus_sign:                                      | Page size. When omitted, the server defaults to `200`.  | 20                                                      |
| `Status`                                                | [TicketStatus](../../Models/Components/TicketStatus.md) | :heavy_minus_sign:                                      | N/A                                                     |                                                         |
| `ForeignID`                                             | *string*                                                | :heavy_minus_sign:                                      | N/A                                                     |                                                         |
| `AccountID`                                             | *string*                                                | :heavy_check_mark:                                      | N/A                                                     |                                                         |