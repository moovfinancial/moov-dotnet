# SweepConfigPaymentMethod

The payment method used to push or pull funds to a bank account.
The push payment method can only be ach-credit-standard, ach-credit-same-day, rtp-credit, or instant-bank-credit (API v2026.01.00 and later). The pull payment method can only be ach-debit-fund.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `PaymentMethodID`                                                                     | *string*                                                                              | :heavy_check_mark:                                                                    | ID of the payment method.                                                             |
| `DisabledOn`                                                                          | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |