# WireTransactionStatus

Status of a transaction within the wire lifecycle.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = WireTransactionStatus.Initiated;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Initiated` | initiated   |
| `Completed` | completed   |
| `Failed`    | failed      |
| `Returned`  | returned    |