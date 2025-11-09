# PlaidLinkIntegration

This is used by Moov.js with a Plaid reseller relationship. The details of a Plaid link integration for a linked funding source.

You can simulate linking bank accounts with Plaid in test mode. See our [test mode](https://docs.moov.io/guides/get-started/test-mode/#plaid)
guide for more information.

Plaid's `sandbox` environment - (requires Plaid reseller setup with Moov). When linking a bank account to a `sandbox` account using a Plaid 
public token it will utilize Plaid's sandbox environment. The Plaid public token provided must be generated from Plaid's sandbox environment. 
Please see <a href="https://plaid.com/docs/api/sandbox/#sandboxpublic_tokencreate" target="_blank">Plaid's sandbox documentation</a> for more 
details.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `PublicToken`      | *string*           | :heavy_check_mark: | N/A                |