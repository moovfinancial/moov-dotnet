# TransferEventType

The event family.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = TransferEventType.Transfer;
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Transfer`          | transfer            |
| `Authorization`     | authorization       |
| `Capture`           | capture             |
| `Refund`            | refund              |
| `Cancellation`      | cancellation        |
| `Dispute`           | dispute             |
| `AchCredit`         | ach-credit          |
| `AchDebit`          | ach-debit           |
| `InstantBankCredit` | instant-bank-credit |
| `WireCredit`        | wire-credit         |
| `CardPayment`       | card-payment        |
| `PushToCard`        | push-to-card        |
| `PullFromCard`      | pull-from-card      |
| `WalletCredit`      | wallet-credit       |
| `WalletDebit`       | wallet-debit        |