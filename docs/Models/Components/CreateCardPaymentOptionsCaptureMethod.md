# CreateCardPaymentOptionsCaptureMethod

How funds are captured. `automatic` (default) authorizes and captures the full amount right away.
`manual` authorizes only; capture later with the capture endpoint.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = CreateCardPaymentOptionsCaptureMethod.Automatic;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Automatic` | automatic   |
| `Manual`    | manual      |