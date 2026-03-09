# DebitHoldPeriod

An optional override of your default ACH hold period in banking days. The hold period must be longer than or equal to your default setting.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = DebitHoldPeriod.NoHold;
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `NoHold`       | no-hold        |
| `OneMinusDay`  | 1-day          |
| `TwoMinusDays` | 2-days         |