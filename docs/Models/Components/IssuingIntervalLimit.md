# IssuingIntervalLimit

Specifies the time frame for a velocity limit. `per-transaction` applies to each individual authorization and never resets. Time-based intervals (where supported) reset at midnight ET.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = IssuingIntervalLimit.PerTransaction;
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `PerTransaction` | per-transaction  |