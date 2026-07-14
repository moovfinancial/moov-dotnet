# PartnerRiskOutcomesResponse

The risk rules that contributed to a transfer's risk decision.

This information has limited availability and must be enabled for your account by Moov.


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `TransferID`                                                                               | *string*                                                                                   | :heavy_check_mark:                                                                         | Identifier of the transfer these outcomes belong to.                                       |
| `ContributingRules`                                                                        | List<[ContributingRule](../../Models/Components/ContributingRule.md)>                      | :heavy_check_mark:                                                                         | The risk rules that contributed to the decision. May be empty when no rules are disclosed. |