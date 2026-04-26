# LinkedGooglePayPaymentMethod


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `PaymentMethodID`                                                         | *string*                                                                  | :heavy_check_mark:                                                        | The new payment method's ID.                                              |
| `PaymentMethodType`                                                       | [PaymentMethodType](../../Models/Components/PaymentMethodType.md)         | :heavy_check_mark:                                                        | The payment method type that represents a payment rail and directionality |
| `GooglePay`                                                               | [GooglePayResponse](../../Models/Components/GooglePayResponse.md)         | :heavy_check_mark:                                                        | Describes a Google Pay token on a Moov account.                           |