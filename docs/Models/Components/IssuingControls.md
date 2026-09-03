# IssuingControls

Mutable spend controls for the card.


## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `SingleUse`                                                                                  | *bool*                                                                                       | :heavy_minus_sign:                                                                           | Indicates if the card is single-use. If true, the card closes after the first authorization. |
| `VelocityLimits`                                                                             | List<[IssuingVelocityLimit](../../Models/Components/IssuingVelocityLimit.md)>                | :heavy_minus_sign:                                                                           | Sets the spending limit per time interval. Only one limit per interval is supported.         |