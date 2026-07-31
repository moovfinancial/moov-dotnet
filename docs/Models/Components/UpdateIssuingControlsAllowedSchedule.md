# UpdateIssuingControlsAllowedSchedule

Replaces the allowed schedule. Set to `null` to remove all schedule restrictions.


## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `Timezone`                                                                                    | *string*                                                                                      | :heavy_minus_sign:                                                                            | IANA timezone string used to evaluate window boundaries against the authorization time.       |
| `Windows`                                                                                     | List<[ScheduleWindow](../../Models/Components/ScheduleWindow.md)>                             | :heavy_minus_sign:                                                                            | Time windows during which the card may authorize. Any matching window allows the transaction. |