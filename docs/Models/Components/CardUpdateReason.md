# CardUpdateReason

The results of the card update request.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = CardUpdateReason.Unspecified;
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Unspecified`       | unspecified         |
| `AccountClosed`     | account-closed      |
| `ContactCardholder` | contact-cardholder  |
| `ExpirationUpdate`  | expiration-update   |
| `NoChange`          | no-change           |
| `NoMatch`           | no-match            |
| `NumberUpdate`      | number-update       |