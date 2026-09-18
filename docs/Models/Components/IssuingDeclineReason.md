# IssuingDeclineReason

The reason an authorization or authorization event was declined. Only present if the
authorization or event has been declined.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = IssuingDeclineReason.InsufficientFunds;
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `InsufficientFunds`             | insufficient-funds              |
| `CardNotActive`                 | card-not-active                 |
| `CardExpiration`                | card-expiration                 |
| `SpendCutoffReached`            | spend-cutoff-reached            |
| `OutsideAllowedSchedule`        | outside-allowed-schedule        |
| `SpendLimitExceeded`            | spend-limit-exceeded            |
| `MerchantCategoryNotSupported`  | merchant-category-not-supported |
| `MerchantCategoryRestricted`    | merchant-category-restricted    |
| `MerchantRestricted`            | merchant-restricted             |
| `MerchantCountryNotSupported`   | merchant-country-not-supported  |
| `UnsupportedTransaction`        | unsupported-transaction         |
| `NetworkStandIn`                | network-stand-in                |
| `DeclinedByIssuer`              | declined-by-issuer              |
| `InvalidRequest`                | invalid-request                 |
| `SystemError`                   | system-error                    |