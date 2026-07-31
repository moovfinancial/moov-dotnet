# UpdateIssuingControlsMerchantRestrictions

Replaces the merchant restrictions. Set to `null` to remove.


## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Mode`                                                                                      | [IssuingControlsRestrictionMode](../../Models/Components/IssuingControlsRestrictionMode.md) | :heavy_minus_sign:                                                                          | Whether the listed merchants are the only ones allowed, or the ones to block.               |
| `Merchants`                                                                                 | List<[MerchantEntry](../../Models/Components/MerchantEntry.md)>                             | :heavy_minus_sign:                                                                          | The merchants to allow or block.                                                            |