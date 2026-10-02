# RiskVerificationOutcome

The outcome of a bank account risk-verification attempt.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = RiskVerificationOutcome.NotAttempted;
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `NotAttempted` | notAttempted   |
| `Success`      | success        |
| `Inconclusive` | inconclusive   |
| `Decline`      | decline        |