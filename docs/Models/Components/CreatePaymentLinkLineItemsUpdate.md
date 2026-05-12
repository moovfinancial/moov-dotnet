# CreatePaymentLinkLineItemsUpdate

An optional collection of line items for a payment link.
When line items are provided, their total plus tax must equal the payment link amount.


## Fields

| Field                                                                                   | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `Items`                                                                                 | List<[CreatePaymentLinkLineItem](../../Models/Components/CreatePaymentLinkLineItem.md)> | :heavy_minus_sign:                                                                      | The list of line items.                                                                 |