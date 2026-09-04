# UpdateIssuingControlsMerchantRestrictions

Restricts card usage to specific merchants, independent of merchant category. Set to `null` to remove merchant restrictions.


## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Mode`                                                                                      | [IssuingControlsRestrictionMode](../../Models/Components/IssuingControlsRestrictionMode.md) | :heavy_minus_sign:                                                                          | Whether the listed items should be allowed (`allow`) or blocked (`block`).                  |
| `Merchants`                                                                                 | List<[MerchantEntry](../../Models/Components/MerchantEntry.md)>                             | :heavy_minus_sign:                                                                          | The merchants to allow or block.                                                            |