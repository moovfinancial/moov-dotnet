# DisputeStatus

The status of a particular dispute. 

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/#dispute-statuses) to learn what each status means.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = DisputeStatus.ResponseNeeded;
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `ResponseNeeded` | response-needed  |
| `Resolved`       | resolved         |
| `UnderReview`    | under-review     |
| `Closed`         | closed           |
| `Accepted`       | accepted         |
| `Expired`        | expired          |
| `Won`            | won              |
| `Lost`           | lost             |