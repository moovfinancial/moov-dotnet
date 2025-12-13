# ScheduledTransferLineItems

An optional collection of line items for a scheduled transfer.
When line items are provided their total must equal `amount` minus `salesTaxAmount`.


## Fields

| Field                                                                                   | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `Items`                                                                                 | List<[ScheduledTransferLineItem](../../Models/Components/ScheduledTransferLineItem.md)> | :heavy_check_mark:                                                                      | The list of line items.                                                                 |