# WalletType

Type of a wallet.
  - `default`: The system-generated wallet automatically created when an account is granted the wallet capability.
  - `general`: An additional, user-defined wallet created via API or Dashboard.
  - `card-issuing`: The system-generated wallet automatically created when an account is granted the card-issuing capability.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = WalletType.Default;
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Default`     | default       |
| `General`     | general       |
| `CardIssuing` | card-issuing  |