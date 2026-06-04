# TransferControls

Controls for transfers created through a given partner


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `AccountID`                                                                  | *string*                                                                     | :heavy_check_mark:                                                           | ID of the merchant account.                                                  |
| `PartnerAccountID`                                                           | *string*                                                                     | :heavy_check_mark:                                                           | ID of the partner account.                                                   |
| `DebtRepayment`                                                              | *bool*                                                                       | :heavy_check_mark:                                                           | Indicates if the account is configured for debt repayment.                   |
| `AllowDynamicDescriptor`                                                     | *bool*                                                                       | :heavy_check_mark:                                                           | Indicates if the account is allowed to set dynamic descriptors on transfers. |
| `AllowSurcharge`                                                             | *bool*                                                                       | :heavy_check_mark:                                                           | Indicates if the account is allowed to apply surcharges to transfers.        |