# PayoutRecipient

Specify the intended recipient of the payout.
Either `email` or `phone` must be specified, but not both.

This information will be used to authenticate the end user when they follow the payment link.


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `Email`                                               | *string*                                              | :heavy_minus_sign:                                    | N/A                                                   | jordan.lee@classbooker.dev                            |
| `Phone`                                               | [PhoneNumber](../../Models/Components/PhoneNumber.md) | :heavy_minus_sign:                                    | N/A                                                   |                                                       |