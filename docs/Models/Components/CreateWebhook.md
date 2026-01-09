# CreateWebhook

Request body for creating a new webhook.


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Url`                                                                 | *string*                                                              | :heavy_check_mark:                                                    | The URL where webhook events will be sent.                            |
| `Status`                                                              | [WebhookStatus](../../Models/Components/WebhookStatus.md)             | :heavy_check_mark:                                                    | The status of the webhook.                                            |
| `EventTypes`                                                          | List<[WebhookEventType](../../Models/Components/WebhookEventType.md)> | :heavy_check_mark:                                                    | The list of event types this webhook should subscribe to.             |
| `Description`                                                         | *string*                                                              | :heavy_check_mark:                                                    | A description of the webhook for reference. Can be an empty string.   |