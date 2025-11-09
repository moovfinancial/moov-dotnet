# IssuedCardState

The `state` represents the operational status of an issued card. A card can only approve incoming authorizations if it is in an active state.

- `active`: The card is operational and approves authorizations. Generally becomes active shortly after card creation.
- `inactive`: The card cannot approve authorizations. This is currently a temporary state assigned post-creation during the activation process.
- `closed`: The card is permanently deactivated and cannot approve authorizations. A card can be closed by request or when it expires.
- `pending-verification`: Awaiting additional authorized user verification before the card can be activated.


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `Active`              | active                |
| `Inactive`            | inactive              |
| `PendingVerification` | pending-verification  |
| `Closed`              | closed                |