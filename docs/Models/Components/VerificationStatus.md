# ~~VerificationStatus~~

Possible states an account verification can be in.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = VerificationStatus.Unverified;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Unverified` | unverified   |
| `Pending`    | pending      |
| `Verified`   | verified     |
| `Errored`    | errored      |