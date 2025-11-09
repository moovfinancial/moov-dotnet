# IndustryTaxonomy

A structured industry taxonomy entry with category and mapped to a default MCC code.


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 | Example                                     |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Industry`                                  | *string*                                    | :heavy_check_mark:                          | Classification identifier for the industry. | clothing-accessories                        |
| `DisplayName`                               | *string*                                    | :heavy_check_mark:                          | Display name of the industry                | Clothing & Accessories                      |
| `Category`                                  | *string*                                    | :heavy_check_mark:                          | Category slug                               | retail                                      |
| `CategoryDisplayName`                       | *string*                                    | :heavy_check_mark:                          | Human-readable category label               | Retail                                      |
| `DefaultMcc`                                | *string*                                    | :heavy_check_mark:                          | Default Merchant Category Code              | 5651                                        |