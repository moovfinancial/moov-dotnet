# IssuedCardState

The `state` represents the operational status of an issued card. A card can only approve incoming authorizations if it is in an active state.

- `active`: The card is operational and can approve authorizations.
- `closed`: The card is permanently deactivated and cannot approve authorizations. A card can be closed by request or when it expires.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = IssuedCardState.Active;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Active` | active   |
| `Closed` | closed   |