# SourceSystem

Identifies the core banking source system that produced the deposit account payload.

The expected format of the request body depends on this value, so it must be supplied
in the `X-Source-System` header on every request.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = SourceSystem.JhSilverlake;
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `JhSilverlake`   | jh_silverlake    |
| `JhCif2020`      | jh_cif2020       |
| `JhCoredirector` | jh_coredirector  |