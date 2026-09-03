# TransferPaymentMethodType

The payment method type that represents a payment rail and directionality

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = TransferPaymentMethodType.MoovWallet;
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `MoovWallet`         | moov-wallet          |
| `AchDebitFund`       | ach-debit-fund       |
| `AchDebitCollect`    | ach-debit-collect    |
| `AchCreditStandard`  | ach-credit-standard  |
| `AchCreditSameDay`   | ach-credit-same-day  |
| `RtpCredit`          | rtp-credit           |
| `CardPayment`        | card-payment         |
| `PushToCard`         | push-to-card         |
| `PullFromCard`       | pull-from-card       |
| `ApplePay`           | apple-pay            |
| `CardPresentPayment` | card-present-payment |
| `InstantBankCredit`  | instant-bank-credit  |
| `PushToApplePay`     | push-to-apple-pay    |
| `PullFromApplePay`   | pull-from-apple-pay  |
| `GooglePay`          | google-pay           |
| `PushToGooglePay`    | push-to-google-pay   |
| `PullFromGooglePay`  | pull-from-google-pay |
| `WireCredit`         | wire-credit          |