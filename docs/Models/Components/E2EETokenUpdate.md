# E2EETokenUpdate

Wraps a compact-serialized JSON Web Encryption (JWE) token used for secure transmission of sensitive data (e.g., PCI information) through intermediaries. 
This token is encrypted using the public key from /end-to-end-keys and wraps an AES key. For details and examples, refer to our 
[GitHub repository](https://github.com/moovfinancial/moov-go/blob/main/examples/e2ee/e2ee_test.go).


## Fields

| Field                                                                                                       | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `Token`                                                                                                     | *string*                                                                                                    | :heavy_minus_sign:                                                                                          | An [RFC](https://datatracker.ietf.org/doc/html/rfc7516) compact-serialized JSON Web Encryption (JWE) token. |