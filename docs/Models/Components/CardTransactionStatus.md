# CardTransactionStatus

Status of a transaction within the card payment lifecycle.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = CardTransactionStatus.Initiated;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Initiated` | initiated   |
| `Confirmed` | confirmed   |
| `Canceled`  | canceled    |
| `Settled`   | settled     |
| `Failed`    | failed      |
| `Completed` | completed   |
| `Deferred`  | deferred    |