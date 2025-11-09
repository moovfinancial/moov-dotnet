# CreateRefund

Specifies a partial amount to refund. 

This request body is optional, an empty body will issue a refund for the full amount of the original transfer.


## Fields

| Field                                                                                     | Type                                                                                      | Required                                                                                  | Description                                                                               | Example                                                                                   |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Amount`                                                                                  | *long*                                                                                    | :heavy_minus_sign:                                                                        | Amount to refund in cents. If null, the original transfer's full amount will be refunded. | 1000                                                                                      |