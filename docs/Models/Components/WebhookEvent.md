# WebhookEvent

Webhook events are sent to your webhook URL when certain actions occur in the Moov API. You can subscribe to these events to receive real-time notifications.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `EventID`                                                                             | *string*                                                                              | :heavy_check_mark:                                                                    | Unique identifier for the webhook event.                                              |
| `Type`                                                                                | [WebhookEventType](../../Models/Components/WebhookEventType.md)                       | :heavy_check_mark:                                                                    | The type of event that occurred.                                                      |
| `Data`                                                                                | [WebhookData](../../Models/Components/WebhookData.md)                                 | :heavy_check_mark:                                                                    | The data for the webhook event. The contents are based on the event type.             |
| `CreatedOn`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | N/A                                                                                   |