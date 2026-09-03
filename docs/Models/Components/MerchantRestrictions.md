# MerchantRestrictions

Restricts card usage to specific merchants, independent of merchant category.


## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Mode`                                                                                      | [IssuingControlsRestrictionMode](../../Models/Components/IssuingControlsRestrictionMode.md) | :heavy_check_mark:                                                                          | Whether the listed items should be allowed (`allow`) or blocked (`block`).                  |
| `Merchants`                                                                                 | List<[MerchantEntry](../../Models/Components/MerchantEntry.md)>                             | :heavy_check_mark:                                                                          | The merchants to allow or block.                                                            |