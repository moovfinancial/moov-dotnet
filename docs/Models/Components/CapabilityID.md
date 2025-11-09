# CapabilityID

Moov account capabilities.

The `production-app`, `platform.production-app`, and / or `platform.wallet-transfers` capabilities might appear in your list. These are read-only capabilities that Moov requests and uses for account verification purposes. These capabilities remains active with your account and require no additional action.


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
| `CollectFunds`                | collect-funds                 |
| `CollectFundsCardPayments`    | collect-funds.card-payments   |
| `MoneyTransferPullFromCard`   | money-transfer.pull-from-card |
| `CollectFundsAch`             | collect-funds.ach             |
| `Wallet`                      | wallet                        |
| `WalletBalance`               | wallet.balance                |
| `CardIssuing`                 | card-issuing                  |
| `ProductionApp`               | production-app                |
| `PlatformProductionApp`       | platform.production-app       |
| `PlatformWalletTransfers`     | platform.wallet-transfers     |