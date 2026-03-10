# InstantBankTransactionStatus

Status of a transaction within the instant-bank lifecycle.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = InstantBankTransactionStatus.Initiated;
```


## Values

| Name                     | Value                    |
| ------------------------ | ------------------------ |
| `Initiated`              | initiated                |
| `Completed`              | completed                |
| `Failed`                 | failed                   |
| `AcceptedWithoutPosting` | accepted-without-posting |