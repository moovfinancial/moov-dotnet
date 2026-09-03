# ACHTransactionStatus

Status of a transaction within the ACH lifecycle.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = ACHTransactionStatus.Unknown;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Unknown`    |              |
| `Initiated`  | initiated    |
| `Originated` | originated   |
| `Corrected`  | corrected    |
| `Returned`   | returned     |
| `Completed`  | completed    |
| `Canceled`   | canceled     |