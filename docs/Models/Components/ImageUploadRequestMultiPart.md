# ImageUploadRequestMultiPart


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Image`                                                                 | [Image](../../Models/Components/Image.md)                               | :heavy_check_mark:                                                      | A PNG, JPEG, or WebP image file to upload.                              |
| `Metadata`                                                              | [ImageMetadataRequest](../../Models/Components/ImageMetadataRequest.md) | :heavy_minus_sign:                                                      | Optional, json-encoded metadata to associate with the uploaded image.   |