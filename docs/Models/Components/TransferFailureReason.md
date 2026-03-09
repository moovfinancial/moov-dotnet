# TransferFailureReason

Reason for a transfer's failure.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = TransferFailureReason.SourcePaymentError;
```


## Values

| Name                      | Value                     |
| ------------------------- | ------------------------- |
| `SourcePaymentError`      | source-payment-error      |
| `DestinationPaymentError` | destination-payment-error |
| `WalletInsufficientFunds` | wallet-insufficient-funds |
| `RejectedHighRisk`        | rejected-high-risk        |
| `ProcessingError`         | processing-error          |