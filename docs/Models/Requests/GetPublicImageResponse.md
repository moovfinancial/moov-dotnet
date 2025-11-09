# GetPublicImageResponse


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `HttpMeta`                                              | [HTTPMetadata](../../Models/Components/HTTPMetadata.md) | :heavy_check_mark:                                      | N/A                                                     |
| `TwoHundredImageWebpBytes`                              | *byte[]*                                                | :heavy_minus_sign:                                      | Response body for returning the raw image bytes.        |
| `TwoHundredImagePngBytes`                               | *byte[]*                                                | :heavy_minus_sign:                                      | Response body for returning the raw image bytes.        |
| `TwoHundredImageJpegBytes`                              | *byte[]*                                                | :heavy_minus_sign:                                      | Response body for returning the raw image bytes.        |
| `Headers`                                               | Dictionary<String, List<*string*>>                      | :heavy_check_mark:                                      | N/A                                                     |