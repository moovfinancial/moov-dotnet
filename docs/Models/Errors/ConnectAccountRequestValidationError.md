# ConnectAccountRequestValidationError


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             | Example                                                 |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `PrincipalAccountID`                                    | *string*                                                | :heavy_minus_sign:                                      | N/A                                                     |                                                         |
| `AllowScopes`                                           | Dictionary<String, *string*>                            | :heavy_minus_sign:                                      | N/A                                                     | {<br/>"0": "first element failed validation..."<br/>}   |
| `HttpMeta`                                              | [HTTPMetadata](../../Models/Components/HTTPMetadata.md) | :heavy_check_mark:                                      | N/A                                                     |                                                         |