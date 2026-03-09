# InstantBankFailureCode

Status codes for instant-bank failures.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = InstantBankFailureCode.ProcessingError;
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
| `CustomerDeceased`        | customer-deceased         |
| `ParticipantNotAvailable` | participant-not-available |
| `Other`                   | other                     |