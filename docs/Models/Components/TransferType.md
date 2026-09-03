# TransferType

The rail and direction used to move funds for a transfer.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = TransferType.CardPayment;
```


## Values

| Name                    | Value                   |
| ----------------------- | ----------------------- |
| `CardPayment`           | card-payment            |
| `PushToCard`            | push-to-card            |
| `PullFromCard`          | pull-from-card          |
| `AchDebit`              | ach-debit               |
| `AchCredit`             | ach-credit              |
| `AchDebitToAchCredit`   | ach-debit-to-ach-credit |
| `InstantBankCredit`     | instant-bank-credit     |
| `Wallet`                | wallet                  |
| `WireCredit`            | wire-credit             |