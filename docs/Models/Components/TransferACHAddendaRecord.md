# TransferACHAddendaRecord

An addenda record which was added to an ACH transfer


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Record`                                                   | *string*                                                   | :heavy_check_mark:                                         | The ACH addenda record, which may have masked PII          |
| `IsMasked`                                                 | *bool*                                                     | :heavy_check_mark:                                         | Flag indicating whether or not this record has been masked |