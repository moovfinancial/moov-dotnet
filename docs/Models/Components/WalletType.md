# WalletType

Type of a wallet.
  - `default`: The system-generated wallet automatically created when an account is granted the wallet capability.
  - `general`: An additional, user-defined wallet created via API or Dashboard.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = WalletType.Default;
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Default` | default   |
| `General` | general   |