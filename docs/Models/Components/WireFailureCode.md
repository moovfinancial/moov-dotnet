# WireFailureCode

Status codes for wire failures.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = WireFailureCode.ProcessingError;
```


## Values

| Name                      | Value                     |
| ------------------------- | ------------------------- |
| `ProcessingError`         | processing-error          |
| `InvalidAccount`          | invalid-account           |
| `AccountClosed`           | account-closed            |
| `AccountBlocked`          | account-blocked           |
| `InvalidField`            | invalid-field             |
| `TransactionNotSupported` | transaction-not-supported |
| `LimitExceeded`           | limit-exceeded            |
| `InvalidAmount`           | invalid-amount            |
| `Other`                   | other                     |