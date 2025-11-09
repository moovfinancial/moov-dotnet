# OnboardingInviteError


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             | Example                                                 |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ReturnURL`                                             | *string*                                                | :heavy_minus_sign:                                      | N/A                                                     |                                                         |
| `TermsOfServiceURL`                                     | *string*                                                | :heavy_minus_sign:                                      | N/A                                                     |                                                         |
| `Scopes`                                                | Dictionary<String, *string*>                            | :heavy_minus_sign:                                      | N/A                                                     | {<br/>"0": "first element failed validation..."<br/>}   |
| `Capabilities`                                          | Dictionary<String, *string*>                            | :heavy_minus_sign:                                      | N/A                                                     | {<br/>"0": "first element failed validation..."<br/>}   |
| `FeePlanCodes`                                          | Dictionary<String, *string*>                            | :heavy_minus_sign:                                      | N/A                                                     | {<br/>"0": "first element failed validation..."<br/>}   |
| `HttpMeta`                                              | [HTTPMetadata](../../Models/Components/HTTPMetadata.md) | :heavy_check_mark:                                      | N/A                                                     |                                                         |