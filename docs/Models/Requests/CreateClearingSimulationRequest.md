# CreateClearingSimulationRequest


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `AccountID`                                                                     | *string*                                                                        | :heavy_check_mark:                                                              | The Moov business account for which the card was issued.                        |
| `AuthorizationID`                                                               | *string*                                                                        | :heavy_check_mark:                                                              | The ID of the authorization to clear.                                           |
| `Body`                                                                          | [CreateClearingSimulation](../../Models/Components/CreateClearingSimulation.md) | :heavy_check_mark:                                                              | N/A                                                                             |