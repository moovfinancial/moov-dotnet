# CapabilityID

Moov account capabilities.

**Deprecated capabilities**

The `send-funds`, `collect-funds`, and `wallet` capability IDs are deprecated. Request granular capabilities instead (for example, `send-funds.ach`, `collect-funds.card-payments`, or `wallet.balance`). Deprecated values will be removed in a future API version.

Read our [capabilities reference](https://docs.moov.io/guides/accounts/capabilities/reference/) to choose the right capabilities for your integration.

The `production-app`, `platform.production-app`, and / or `platform.wallet-transfers` capabilities might appear in the list for your Partner account. These are read-only capabilities that Moov requests. These capabilities remain active with your account and require no additional action.

## Example Usage

```csharp
using Moov.Sdk.Models.Components;

var value = CapabilityID.Transfers;
```


## Values

| Name                          | Value                         |
| ----------------------------- | ----------------------------- |
| `Transfers`                   | transfers                     |
| `SendFunds`                   | send-funds                    |
| `SendFundsPushToCard`         | send-funds.push-to-card       |
| `MoneyTransferPushToCard`     | money-transfer.push-to-card   |
| `SendFundsAch`                | send-funds.ach                |
| `SendFundsRtp`                | send-funds.rtp                |
| `SendFundsInstantBank`        | send-funds.instant-bank       |
| `SendFundsWire`               | send-funds.wire               |
| `CollectFunds`                | collect-funds                 |
| `CollectFundsCardPayments`    | collect-funds.card-payments   |
| `MoneyTransferPullFromCard`   | money-transfer.pull-from-card |
| `CollectFundsAch`             | collect-funds.ach             |
| `Wallet`                      | wallet                        |
| `WalletBalance`               | wallet.balance                |
| `CardIssuing`                 | card-issuing                  |
| `IssuingCardholder`           | issuing.cardholder            |
| `ProductionApp`               | production-app                |
| `PlatformProductionApp`       | platform.production-app       |
| `PlatformWalletTransfers`     | platform.wallet-transfers     |