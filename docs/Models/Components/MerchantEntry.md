# MerchantEntry

Identifies a merchant by ID, descriptor pattern, or both. At least one of `mid` or `descriptorPattern` must be set.


## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `Mid`                                                                                              | *string*                                                                                           | :heavy_minus_sign:                                                                                 | The merchant's unique identifier (ISO 8583 DE42), matched exactly.                                 |
| `DescriptorPattern`                                                                                | *string*                                                                                           | :heavy_minus_sign:                                                                                 | A case-insensitive RE2 regular expression matched against the merchant descriptor (ISO 8583 DE43). |
| `Name`                                                                                             | *string*                                                                                           | :heavy_minus_sign:                                                                                 | An optional label for this entry.                                                                  |