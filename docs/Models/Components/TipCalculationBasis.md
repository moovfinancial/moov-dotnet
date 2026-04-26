# TipCalculationBasis

Defines which amount should be used when calculating the final payment total. This calculation applies for percentage tip values.
- `pre-tax`: Tip amounts are calculated using the subtotal amount before taxes
- `post-tax`: Tip amounts are calculated using the subtotal amount + taxes

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = TipCalculationBasis.PreTax;
```


## Values

| Name      | Value     |
| --------- | --------- |
| `PreTax`  | pre-tax   |
| `PostTax` | post-tax  |