# DownloadFileResponse


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `HttpMeta`                                              | [HTTPMetadata](../../Models/Components/HTTPMetadata.md) | :heavy_check_mark:                                      | N/A                                                     |
| `TwoHundredApplicationPdfBytes`                         | *byte[]*                                                | :heavy_minus_sign:                                      | Response body for returning the raw contents of a file. |
| `TwoHundredImagePngBytes`                               | *byte[]*                                                | :heavy_minus_sign:                                      | Response body for returning the raw contents of a file. |
| `TwoHundredImageJpegBytes`                              | *byte[]*                                                | :heavy_minus_sign:                                      | Response body for returning the raw contents of a file. |
| `TwoHundredTextPlainBytes`                              | *byte[]*                                                | :heavy_minus_sign:                                      | Response body for returning the raw contents of a file. |
| `TwoHundredApplicationOctetStreamBytes`                 | *byte[]*                                                | :heavy_minus_sign:                                      | Response body for returning the raw contents of a file. |
| `Headers`                                               | Dictionary<String, List<*string*>>                      | :heavy_check_mark:                                      | N/A                                                     |