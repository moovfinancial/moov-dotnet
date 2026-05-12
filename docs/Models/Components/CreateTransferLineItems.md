# CreateTransferLineItems

An optional collection of line items for a transfer.
When line items are provided, their total plus tax must equal the transfer amount.


## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `Items`                                                                           | List<[CreateTransferLineItem](../../Models/Components/CreateTransferLineItem.md)> | :heavy_check_mark:                                                                | The list of line items.                                                           |