# UpdateIssuedCardState

Updates the state of a Moov issued card.
- `active`: The card is operational and authorizations can be approved.
- `frozen`: The card is temporarily suspended and authorizations cannot be approved. Set the state back to `active` to reactivate it. A card can move between `frozen` and `active` as often as needed.
- `closed`: The card is permanently deactivated. A card is closed by request or when it expires, and cannot be reopened.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = UpdateIssuedCardState.Active;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Active` | active   |
| `Frozen` | frozen   |
| `Closed` | closed   |