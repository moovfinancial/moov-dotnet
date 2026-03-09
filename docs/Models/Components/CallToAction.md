# CallToAction

The text to be displayed on web form's submit button.

If set to "auto" the UI will automatically select between 
"pay" and "confirm" for payments and payouts respectively.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = CallToAction.Pay;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pay`       | pay         |
| `Book`      | book        |
| `Subscribe` | subscribe   |
| `Donate`    | donate      |
| `Confirm`   | confirm     |
| `Auto`      | auto        |