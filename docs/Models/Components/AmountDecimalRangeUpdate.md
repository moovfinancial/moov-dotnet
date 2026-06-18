# AmountDecimalRangeUpdate

A range of values that an AmountDecimal can take.

If either `minimum` or `maximum` is omitted, the range is "open" on that end:

`minimum` specified: `amt >= minimum`
`maximum` specified: `amt <= maximum`
both specified: `minimum <= amt <= maximum`


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Minimum`                                                             | [AmountDecimalUpdate](../../Models/Components/AmountDecimalUpdate.md) | :heavy_minus_sign:                                                    | Minimum amount allowed in the range                                   |
| `Maximum`                                                             | [AmountDecimalUpdate](../../Models/Components/AmountDecimalUpdate.md) | :heavy_minus_sign:                                                    | Maximum amount allowed in the range                                   |