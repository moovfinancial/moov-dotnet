# UpdateIssuedCardState

Updates the state of a Moov issued card.
- `closed`: The card is permanently deactivated and cannot approve authorizations. A card can be closed by request or when it expires.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = UpdateIssuedCardState.Closed;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Closed` | closed   |