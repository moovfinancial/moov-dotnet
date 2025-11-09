# LinkApplePaymentMethod

  Provides information about the underlying card.

  Refer to [Apple's documentation](https://developer.apple.com/documentation/apple_pay_on_the_web/applepaypaymenttoken/1916113-paymentmethod) 
  for more information.


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 | Example                                     |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `DisplayName`                               | *string*                                    | :heavy_check_mark:                          | A display-friendly discription of the card. | Visa 1234                                   |
| `Network`                                   | *string*                                    | :heavy_check_mark:                          | The card's payment network.                 | Visa                                        |
| `Type`                                      | *string*                                    | :heavy_check_mark:                          | The type of card.                           | debit                                       |