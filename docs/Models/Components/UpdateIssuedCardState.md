# UpdateIssuedCardState

Updates the state of a Moov issued card.
- `active`: Reactivates a frozen card so it can approve authorizations again.
- `frozen`: Temporarily suspends the card so it cannot approve authorizations. A card can be moved between `frozen` and `active` at will until it is `closed`, which is a terminal state.
- `closed`: The card is permanently deactivated and cannot approve authorizations. A card can be closed by request or when it expires.

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