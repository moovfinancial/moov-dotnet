# PaymentLinkCustomerOptions


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `RequireAddress`                                                                    | *bool*                                                                              | :heavy_minus_sign:                                                                  | If true, a billing address is required when completing the payment form.            |
| `RequirePhone`                                                                      | *bool*                                                                              | :heavy_minus_sign:                                                                  | If true, a phone number is required when completing the payment form.               |
| `Metadata`                                                                          | Dictionary<String, *string*>                                                        | :heavy_minus_sign:                                                                  | Optional free-form metadata for the Moov account that will represent this customer. |