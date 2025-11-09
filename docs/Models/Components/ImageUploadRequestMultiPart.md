# ImageUploadRequestMultiPart

Multipart request body for uploading an image with optional metadata.


## Fields

| Field                                                                                           | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `Image`                                                                                         | [ImageUploadRequestMultiPartImage](../../Models/Components/ImageUploadRequestMultiPartImage.md) | :heavy_check_mark:                                                                              | N/A                                                                                             |
| `Metadata`                                                                                      | [ImageMetadataRequest](../../Models/Components/ImageMetadataRequest.md)                         | :heavy_minus_sign:                                                                              | Optional, json-encoded metadata to associate with the uploaded image.                           |