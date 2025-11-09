# LinkedApplePayPaymentMethod


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `PaymentMethodID`                                                         | *string*                                                                  | :heavy_check_mark:                                                        | The new payment method's ID.                                              |
| `PaymentMethodType`                                                       | [PaymentMethodType](../../Models/Components/PaymentMethodType.md)         | :heavy_check_mark:                                                        | The payment method type that represents a payment rail and directionality |
| `ApplePay`                                                                | [ApplePayResponse](../../Models/Components/ApplePayResponse.md)           | :heavy_check_mark:                                                        | Describes an Apple Pay token on a Moov account.                           |