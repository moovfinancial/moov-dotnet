# DomesticPushToCard

Indicates which level of domestic push-to-card transfer is supported by the card, if any.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = DomesticPushToCard.NotSupported;
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `NotSupported` | not-supported  |
| `Standard`     | standard       |
| `FastFunds`    | fast-funds     |
| `Unknown`      | unknown        |