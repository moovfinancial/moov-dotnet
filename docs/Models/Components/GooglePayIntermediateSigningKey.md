# GooglePayIntermediateSigningKey

Contains the intermediate signing key for verification.


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `SignedKey`                                                       | *string*                                                          | :heavy_check_mark:                                                | A JSON-encoded serialized string containing the signing key data. |
| `Signatures`                                                      | List<*string*>                                                    | :heavy_check_mark:                                                | Base64-encoded signatures of the `signedKey`.                     |