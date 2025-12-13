# Moov SDK

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *Moov* API.

<div align="left" style="margin-bottom: 0;">
    <a href="https://www.speakeasy.com/?utm_source=moov-sdk&utm_campaign=csharp" class="badge-link">
        <span class="badge-container">
            <span class="badge-icon-section">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" viewBox="0 0 30 30" fill="none" style="vertical-align: middle;"><title>Speakeasy Logo</title><path fill="currentColor" d="m20.639 27.548-19.17-2.724L0 26.1l20.639 2.931 8.456-7.336-1.468-.208-6.988 6.062Z"></path><path fill="currentColor" d="m20.639 23.1 8.456-7.336-1.468-.207-6.988 6.06-6.84-.972-9.394-1.333-2.936-.417L0 20.169l2.937.416L0 23.132l20.639 2.931 8.456-7.334-1.468-.208-6.986 6.062-9.78-1.39 1.468-1.273 8.31 1.18Z"></path><path fill="currentColor" d="m20.639 18.65-19.17-2.724L0 17.201l20.639 2.931 8.456-7.334-1.468-.208-6.988 6.06Z"></path><path fill="currentColor" d="M27.627 6.658 24.69 9.205 20.64 12.72l-7.923-1.126L1.469 9.996 0 11.271l11.246 1.596-1.467 1.275-8.311-1.181L0 14.235l20.639 2.932 8.456-7.334-2.937-.418 2.937-2.549-1.468-.208Z"></path><path fill="currentColor" d="M29.095 3.902 8.456.971 0 8.305l20.639 2.934 8.456-7.337Z"></path></svg>
            </span>
            <span class="badge-text badge-text-section">BUILT BY SPEAKEASY</span>
        </span>
    </a>
    <a href="https://opensource.org/licenses/Apache-2.0" class="badge-link">
        <span class="badge-container blue">
            <span class="badge-text badge-text-section">LICENSE // Apache 2.0</span>
        </span>
    </a>
</div>


<br /><br />
> [!IMPORTANT]
> This SDK is not yet ready for production use. To complete setup please follow the steps outlined in your [workspace](https://app.speakeasy.com/org/moov/moov). Delete this section before > publishing to a package manager.

<!-- Start Summary [summary] -->
## Summary

Moov API: Moov is a platform that enables developers to integrate all aspects of money movement with ease and speed.
The Moov API makes it simple for platforms to send, receive, and store money. Our API is based upon REST
principles, returns JSON responses, and uses standard HTTP response codes. To learn more about how Moov
works at a high level, read our [concepts](https://docs.moov.io/guides/get-started/glossary/) guide.

For more information about the API: [Moov Guides and API Documentation](https://docs.moov.io/)
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [Moov SDK](#moov-sdk)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
  * [Custom HTTP Client](#custom-http-client)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package Moov.Sdk
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/Moov/Sdk/Moov.Sdk.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Accounts.CreateAsync(body: new CreateAccount() {
    AccountType = CreateAccountType.Business,
    Profile = new CreateProfile() {
        Business = new CreateBusinessProfile() {
            LegalBusinessName = "Whole Body Fitness LLC",
        },
    },
});

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                      | Type | Scheme     |
| ------------------------- | ---- | ---------- |
| `Username`<br/>`Password` | http | HTTP Basic |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(
    security: new Security() {
        Username = "",
        Password = "",
    },
    xMoovVersion: "<value>"
);

var res = await sdk.Accounts.CreateAsync(body: new CreateAccount() {
    AccountType = CreateAccountType.Business,
    Profile = new CreateProfile() {
        Business = new CreateBusinessProfile() {
            LegalBusinessName = "Whole Body Fitness LLC",
        },
    },
});

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [AccountTerminalApplications](docs/sdks/accountterminalapplications/README.md)

* [Link](docs/sdks/accountterminalapplications/README.md#link) - Link an account with a terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.write` scope.
* [List](docs/sdks/accountterminalapplications/README.md#list) - Retrieve all terminal applications linked to a specific account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.read` scope.
* [Get](docs/sdks/accountterminalapplications/README.md#get) - Verifies if a specific Terminal Application is linked to an Account. This endpoint acts as a validation check for the link's existence.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-applications.read` scope.
* [GetConfiguration](docs/sdks/accountterminalapplications/README.md#getconfiguration) - Fetch the configuration for a given Terminal Application linked to a specific Account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/terminal-configuration.read` scope.

### [Accounts](docs/sdks/accounts/README.md)

* [Create](docs/sdks/accounts/README.md#create) - You can create **business** or **individual** accounts for your users (i.e., customers, merchants) by passing the required
information to Moov. Requirements differ per account type and requested [capabilities](https://docs.moov.io/guides/accounts/capabilities/requirements/).

If you're requesting the `wallet`, `send-funds`, `collect-funds`, or `card-issuing` capabilities, you'll need to:
  + Send Moov the user [platform terms of service agreement](https://docs.moov.io/guides/accounts/requirements/platform-agreement/) acceptance.
    This can be done upon account creation, or by [patching](https://docs.moov.io/api/moov-accounts/accounts/patch/) the account using the `termsOfService` field.
If you're creating a business account with the business type `llc`, `partnership`, or `privateCorporation`, you'll need to:
  + Provide [business representatives](https://docs.moov.io/api/moov-accounts/representatives/) after creating the account.
  + [Patch](https://docs.moov.io/api/moov-accounts/accounts/patch/) the account to indicate that business representative ownership information is complete.

Visit our documentation to read more about [creating accounts](https://docs.moov.io/guides/accounts/create-accounts/) and [verification requirements](https://docs.moov.io/guides/accounts/requirements/identity-verification/).
Note that the `mode` field (for production or sandbox) is only required when creating a _facilitator_ account. All non-facilitator account requests will ignore the mode field and be set to the calling facilitator's mode.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts.write` scope.
* [List](docs/sdks/accounts/README.md#list) - List or search accounts to which the caller is connected.

All supported query parameters are optional. If none are provided the response will include all connected accounts.
Pagination is supported via the `skip` and `count` query parameters. Searching by name and email will overlap and 
return results based on relevance. Accounts with AccountType `guest` will not be included in the response.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts.read` scope.
* [Get](docs/sdks/accounts/README.md#get) - Retrieves details for the account with the specified ID.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts/{accountID}/profile.read` scope.
* [Update](docs/sdks/accounts/README.md#update) - When **can** profile data be updated:
  + For unverified accounts, all profile data can be edited.
  + During the verification process, missing or incomplete profile data can be edited.
  + Verified accounts can only add missing profile data.

  When **can't** profile data be updated:
  + Verified accounts cannot change any existing profile data.

If you need to update information in a locked state, please contact Moov support.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) you'll need
to specify the `/accounts/{accountID}/profile.write` scope.
* [Disconnect](docs/sdks/accounts/README.md#disconnect) - This will sever the connection between you and the account specified and it will no longer be listed as 
active in the list of accounts. This also means you'll only have read-only access to the account going 
forward for reporting purposes.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.disconnect` scope.
* [GetCountries](docs/sdks/accounts/README.md#getcountries) - Retrieve the specified countries of operation for an account. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [AssignCountries](docs/sdks/accounts/README.md#assigncountries) - Assign the countries of operation for an account.

This endpoint will always overwrite the previously assigned values. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.
* [GetMerchantProcessingAgreement](docs/sdks/accounts/README.md#getmerchantprocessingagreement) - Retrieve a merchant account's processing agreement.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [GetTermsOfServiceToken](docs/sdks/accounts/README.md#gettermsofservicetoken) - Generates a non-expiring token that can then be used to accept Moov's terms of service. 

This token can only be generated via API. Any Moov account requesting the collect funds, send funds, wallet, 
or card issuing capabilities must accept Moov's terms of service, then have the generated terms of service 
token patched to the account. Read more in our [documentation](https://docs.moov.io/guides/accounts/requirements/platform-agreement/).

### [Adjustments](docs/sdks/adjustments/README.md)

* [List](docs/sdks/adjustments/README.md#list) - List adjustments associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Get](docs/sdks/adjustments/README.md#get) - Retrieve a specific adjustment associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### [ApplePay](docs/sdks/applepay/README.md)

* [RegisterMerchantDomains](docs/sdks/applepay/README.md#registermerchantdomains) - Add domains to be registered with Apple Pay.

Any domains that will be used to accept payments must first be [verified](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) 
with Apple.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.
* [UpdateMerchantDomains](docs/sdks/applepay/README.md#updatemerchantdomains) - Add or remove domains to be registered with Apple Pay.

Any domains that will be used to accept payments must first be [verified](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains)
with Apple.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.
* [GetMerchantDomains](docs/sdks/applepay/README.md#getmerchantdomains) - Get domains registered with Apple Pay. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.read` scope.
* [CreateSession](docs/sdks/applepay/README.md#createsession) - Create a session with Apple Pay to facilitate a payment. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 
A successful response from this endpoint should be passed through to Apple Pay unchanged. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/apple-pay.write` scope.
* [LinkToken](docs/sdks/applepay/README.md#linktoken) - Connect an Apple Pay token to the specified account. 

Read our [Apple Pay tutorial](https://docs.moov.io/guides/sources/cards/apple-pay/#register-your-domains) to learn more. 
The `token` data is defined by Apple Pay and should be passed through from Apple Pay's response unmodified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/cards.write` scope.

### [Authentication](docs/sdks/authentication/README.md)

* [RevokeAccessToken](docs/sdks/authentication/README.md#revokeaccesstoken) - Revoke an auth token.

Allows clients to notify the authorization server that a previously obtained refresh or access token is no longer needed.
* [CreateAccessToken](docs/sdks/authentication/README.md#createaccesstoken) - Create or refresh an access token.

### [Avatars](docs/sdks/avatars/README.md)

* [Get](docs/sdks/avatars/README.md#get) - Get avatar image for an account using a unique ID.    

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/profile-enrichment.read` scope.

### [BankAccounts](docs/sdks/bankaccounts/README.md)

* [Link](docs/sdks/bankaccounts/README.md#link) - Link a bank account to an existing Moov account. Read our [bank accounts guide](https://docs.moov.io/guides/sources/bank-accounts/) to learn more.

It is strongly recommended that callers include the `X-Wait-For` header, set to `payment-method`, if the newly linked
bank-account is intended to be used right away. If this header is not included, the caller will need to poll the [List Payment
Methods](https://docs.moov.io/api/sources/payment-methods/list/)
endpoint to wait for the new payment methods to be available for use.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.write` scope.
* [List](docs/sdks/bankaccounts/README.md#list) - List all the bank accounts associated with a particular Moov account. 

Read our [bank accounts guide](https://docs.moov.io/guides/sources/bank-accounts/) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.read` scope.
* [Get](docs/sdks/bankaccounts/README.md#get) - Retrieve bank account details (i.e. routing number or account type) associated with a specific Moov account. 

Read our [bank accounts guide](https://docs.moov.io/guides/sources/bank-accounts/) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.read` scope.
* [Disable](docs/sdks/bankaccounts/README.md#disable) - Discontinue using a specified bank account linked to a Moov account. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.write` scope.
* [InitiateMicroDeposits](docs/sdks/bankaccounts/README.md#initiatemicrodeposits) - Micro-deposits help confirm bank account ownership, helping reduce fraud and the risk of unauthorized activity. 
Use this method to initiate the micro-deposit verification, sending two small credit transfers to the bank account 
you want to confirm.

If you request micro-deposits before 4:15PM ET, they will appear that same day. If you request micro-deposits any 
time after 4:15PM ET, they will appear the next banking day. When the two credits are initiated, Moov simultaneously
initiates a debit to recoup the micro-deposits. 

Micro-deposits initiated for a `sandbox` bank account will always be `$0.00` / `$0.00` and instantly verifiable once initiated.

You can simulate micro-deposit verification in test mode. See our [test mode](https://docs.moov.io/guides/get-started/test-mode/#micro-deposits)
guide for more information.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.write` scope.
* [CompleteMicroDeposits](docs/sdks/bankaccounts/README.md#completemicrodeposits) - Complete the micro-deposit validation process by passing the amounts of the two transfers within three tries.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.write` scope.
* [GetVerification](docs/sdks/bankaccounts/README.md#getverification) - Retrieve the current status and details of an instant verification, including whether the verification method was instant (RTP or FedNow) or same-day
ACH. This helps track the verification process in real-time and provides details in case of exceptions.

The status will indicate the following:

- `new`: Verification initiated, credit pending to the payment network
- `sent-credit`: Credit sent, available for verification
- `failed`: Verification failed, description provided, user needs to add a new bank account
- `expired`: Verification expired after 14 days, initiate another verification
- `max-attempts-exceeded`: Five incorrect code attempts exhausted, initiate another verification

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.read` scope.
* [InitiateVerification](docs/sdks/bankaccounts/README.md#initiateverification) - Instant micro-deposit verification offers a quick and efficient way to verify bank account ownership. 

Send a $0.01 credit with a unique verification code via RTP, FedNow, or same-day ACH, depending on the receiving bank's capabilities. This
feature provides a faster alternative to traditional methods, allowing verification in a single session.

It is recommended to use the `X-Wait-For: rail-response` header to synchronously receive the outcome of the instant credit in the
  response payload.

Possible verification methods:
  - `instant`: Real-time verification credit sent via RTP or FedNow
  - `ach`: Verification credit sent via same-day ACH

Possible statuses:
  - `new`: Verification initiated, credit pending
  - `sent-credit`: Credit sent, available for verification in the external bank account
  - `failed`: Verification failed due to credit rejection/return, details in `exceptionDetails`

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.write` scope.
* [CompleteVerification](docs/sdks/bankaccounts/README.md#completeverification) - Finalize the instant micro-deposit verification by submitting the verification code displayed in the user's bank account. 

Upon successful verification, the bank account status will be updated to `verified` and eligible for ACH debit transactions.

The following formats are accepted:
- `MV0000`
- `mv0000`
- `0000`

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/bank-accounts.write` scope.

### [Branding](docs/sdks/branding/README.md)

* [Create](docs/sdks/branding/README.md#create) - Create brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.write` scope.
* [Upsert](docs/sdks/branding/README.md#upsert) - Create or replace brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.write` scope.
* [Get](docs/sdks/branding/README.md#get) - Get brand properties for the specified account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/branding.read` scope.

### [Capabilities](docs/sdks/capabilities/README.md)

* [List](docs/sdks/capabilities/README.md#list) - Retrieve all the capabilities an account has requested.

Read our [capabilities guide](https://docs.moov.io/guides/accounts/capabilities/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/capabilities.read` scope.
* [Request](docs/sdks/capabilities/README.md#request) - Request capabilities for a specific account. Read our [capabilities guide](https://docs.moov.io/guides/accounts/capabilities/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/capabilities.write` scope.
* [Get](docs/sdks/capabilities/README.md#get) - Retrieve a specific capability that an account has requested. Read our [capabilities guide](https://docs.moov.io/guides/accounts/capabilities/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/capabilities.read` scope.
* [Disable](docs/sdks/capabilities/README.md#disable) - Disable a specific capability that an account has requested. Read our [capabilities guide](https://docs.moov.io/guides/accounts/capabilities/) to learn more.

  To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/capabilities.write` scope.

### [CardIssuing](docs/sdks/cardissuing/README.md)

* [Request](docs/sdks/cardissuing/README.md#request) - Request a virtual card be issued.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.write` scope.
* [List](docs/sdks/cardissuing/README.md#list) - List Moov issued cards existing for the account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [Get](docs/sdks/cardissuing/README.md#get) - Retrieve a single issued card associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [Update](docs/sdks/cardissuing/README.md#update) - Update a Moov issued card.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/issued-cards.write` scope.
* [GetFull](docs/sdks/cardissuing/README.md#getfull) - Get issued card with PAN, CVV, and expiration. 

Only use this endpoint if you have provided Moov with a copy of your PCI attestation of compliance.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read-secure` scope.

### [Cards](docs/sdks/cards/README.md)

* [Link](docs/sdks/cards/README.md#link) - Link a card to an existing Moov account. 

Read our [accept card payments guide](https://docs.moov.io/guides/sources/cards/accept-card-payments/#link-a-card) to learn more.

Only use this endpoint if you have provided Moov with a copy of your PCI attestation of compliance. 

During card linking, the provided data will be verified by submitting a $0 authorization (account verification) request. 
If `merchantAccountID` is provided, the authorization request will contain that account's statement descriptor and address. 
Otherwise, the platform account's profile will be used. If no statement descriptor has been set, the authorization will 
use the account's name instead.

It is strongly recommended that callers include the `X-Wait-For` header, set to `payment-method`, if the newly linked 
card is intended to be used right away. If this header is not included, the caller will need to poll the [List Payment 
Methods](https://docs.moov.io/api/sources/payment-methods/list/)
endpoint to wait for the new payment methods to be available for use.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/cards.write` scope.
* [List](docs/sdks/cards/README.md#list) - List all the active cards associated with a Moov account. 

Read our [accept card payments guide](https://docs.moov.io/guides/sources/cards/accept-card-payments/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/cards.read` scope.
* [Get](docs/sdks/cards/README.md#get) - Fetch a specific card associated with a Moov account. 

Read our [accept card payments guide](https://docs.moov.io/guides/sources/cards/accept-card-payments/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/cards.read` scope.
* [Update](docs/sdks/cards/README.md#update) - Update a linked card and/or resubmit it for verification.

If a value is provided for CVV, a new verification ($0 authorization) will be submitted for the card. Updating the expiration
date or
address will update the information stored on file for the card but will not be verified.

Read our [accept card payments guide](https://docs.moov.io/guides/sources/cards/accept-card-payments/#reverify-a-card) to learn
more.

Only use this endpoint if you have provided Moov with a copy of your PCI attestation of compliance.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/cards.write` scope.
* [Disable](docs/sdks/cards/README.md#disable) - Disables a card associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/cards.write` scope.

### [Disputes](docs/sdks/disputes/README.md)

* [List](docs/sdks/disputes/README.md#list) - Returns the list of disputes. 

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Get](docs/sdks/disputes/README.md#get) - Get a dispute by ID. 

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Accept](docs/sdks/disputes/README.md#accept) - Accepts liability for a dispute. 

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [ListEvidence](docs/sdks/disputes/README.md#listevidence) - Returns a dispute's public evidence by its ID. 

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [UploadEvidenceFile](docs/sdks/disputes/README.md#uploadevidencefile) - Uploads a file as evidence for a dispute. 

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [UploadEvidenceText](docs/sdks/disputes/README.md#uploadevidencetext) - Uploads text as evidence for a dispute.

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [SubmitEvidence](docs/sdks/disputes/README.md#submitevidence) - Submit the evidence associated with a dispute.

Evidence items must be uploaded using the appropriate endpoint(s) prior to calling this endpoint to submit it. **Evidence can only
be submitted once per dispute.**

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [GetEvidence](docs/sdks/disputes/README.md#getevidence) - Get dispute evidence by ID.

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [UpdateEvidence](docs/sdks/disputes/README.md#updateevidence) - Updates dispute evidence by ID.

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [DeleteEvidence](docs/sdks/disputes/README.md#deleteevidence) - Deletes dispute evidence by ID. 

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [GetEvidenceData](docs/sdks/disputes/README.md#getevidencedata) - Downloads dispute evidence data by ID.

Read our [disputes guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/disputes/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### [EndToEndEncryption](docs/sdks/endtoendencryption/README.md)

* [TestEncryptedToken](docs/sdks/endtoendencryption/README.md#testencryptedtoken) - Allows for testing a JWE token to ensure it's acceptable by Moov. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/ping.read` scope.
* [GenerateKey](docs/sdks/endtoendencryption/README.md#generatekey) - Generates a public key used to create a JWE token for passing secure authentication data through non-PCI compliant intermediaries.

### [EnrichedAddress](docs/sdks/enrichedaddress/README.md)

* [Get](docs/sdks/enrichedaddress/README.md#get) - Fetch enriched address suggestions. Requires a partial address. 
  
To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/profile-enrichment.read` scope.

### [EnrichedProfile](docs/sdks/enrichedprofile/README.md)

* [Get](docs/sdks/enrichedprofile/README.md#get) - Fetch enriched profile data. Requires a valid email address. This service is offered in collaboration with Clearbit. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/profile-enrichment.read` scope.

### [FeePlans](docs/sdks/feeplans/README.md)

* [ListFeePlanAgreements](docs/sdks/feeplans/README.md#listfeeplanagreements) - List all fee plan agreements associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [CreateFeePlanAgreements](docs/sdks/feeplans/README.md#createfeeplanagreements) - Creates the subscription of a fee plan to a merchant account. Merchants are required to accept the fee plan terms prior to activation.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.
* [ListFeePlans](docs/sdks/feeplans/README.md#listfeeplans) - List all fee plans available for use by an account. This is intended to be used by an account when 
selecting a fee plan to apply to a connected account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [ListFeeRevenue](docs/sdks/feeplans/README.md#listfeerevenue) - Used by a partner. Retrieve revenue generated from merchant fees.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [RetrieveFees](docs/sdks/feeplans/README.md#retrievefees) - Retrieve fees assessed to an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [ListFeesFetch](docs/sdks/feeplans/README.md#listfeesfetch) - List fees associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [ListPartnerPricing](docs/sdks/feeplans/README.md#listpartnerpricing) - List all partner pricing plans available for use by an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [ListPartnerPricingAgreements](docs/sdks/feeplans/README.md#listpartnerpricingagreements) - List all partner pricing agreements associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [ListResiduals](docs/sdks/feeplans/README.md#listresiduals) - List all residuals associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [GetResidual](docs/sdks/feeplans/README.md#getresidual) - Get a residual associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [ListResidualFees](docs/sdks/feeplans/README.md#listresidualfees) - List all fees associated with a residual.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### [Files](docs/sdks/files/README.md)

* [Upload](docs/sdks/files/README.md#upload) - Upload a file and link it to the specified Moov account. 

The maximum file size is 20MB. Each account is allowed a maximum of 50 files. Acceptable file types include csv, jpg, pdf, 
and png. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.write` scope.
* [List](docs/sdks/files/README.md#list) - List all the files associated with a particular Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.read` scope.
* [Get](docs/sdks/files/README.md#get) - Retrieve file details associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/files.read` scope.

### [Images](docs/sdks/images/README.md)

* [List](docs/sdks/images/README.md#list) - List metadata for all images in the specified account.
* [Upload](docs/sdks/images/README.md#upload) -   Upload a new PNG, JPEG, or WebP image with optional metadata. 
  Duplicate images, and requests larger than 16MB will be rejected.
* [GetMetadata](docs/sdks/images/README.md#getmetadata) - Retrieve metadata for a specific image by its ID.
* [Update](docs/sdks/images/README.md#update) - Replace an existing image and, optionally, its metadata.

This endpoint replaces the existing image with the new PNG, JPEG, or WebP. Omit
the metadata form section to keep existing metadata. Duplicate images, and requests larger than 16MB will be rejected.
* [Delete](docs/sdks/images/README.md#delete) - Permanently delete an image by its ID.
* [UpdateMetadata](docs/sdks/images/README.md#updatemetadata) - Replace the metadata for an existing image.
* [GetPublic](docs/sdks/images/README.md#getpublic) - Get an image by its public ID.

### [Industries](docs/sdks/industries/README.md)

* [List](docs/sdks/industries/README.md#list) - Returns a list of industries relevant to merchant profile enrichment.  Results are ordered by industry name.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/),
you'll need to specify the `/profile-enrichment.read` scope.

### [Institutions](docs/sdks/institutions/README.md)

* [SearchInstitutions](docs/sdks/institutions/README.md#searchinstitutions) - Search for financial institutions by name or routing number.

This endpoint returns metadata about each matched institution, including basic identifying details (such as name, routing number, and address) and information about which payment services they support (e.g., ACH, RTP, and Wire).

This can be used to validate a financial institution before initiating payment activity, or to check which payment rails are available for a given routing number.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/institutions.read` scope.
* [~~Search~~](docs/sdks/institutions/README.md#search) - This endpoint has been deprecated and will be removed in a future release. Use [/institutions](https://docs.moov.io/api/enrichment/form-shortening/institutions/get/).

Search for institutions by either their name or routing number.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/fed.read` scope. :warning: **Deprecated**

### [Invoices](docs/sdks/invoices/README.md)

* [CreateInvoice](docs/sdks/invoices/README.md#createinvoice) - Create an invoice for a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.
* [ListInvoices](docs/sdks/invoices/README.md#listinvoices) - List all the invoices created under a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/invoices.read` scope.
* [GetInvoice](docs/sdks/invoices/README.md#getinvoice) - Retrieve an invoice by ID.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/invoices.read` scope.
* [UpdateInvoice](docs/sdks/invoices/README.md#updateinvoice) - Updates an invoice.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.
* [MarkPaidInvoice](docs/sdks/invoices/README.md#markpaidinvoice) - Marks an invoice as paid outside of the Moov platform.
If a payment link was created, the corresponding payment link is canceled, but a receipt is still sent.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/invoices.write` scope.

### [IssuingTransactions](docs/sdks/issuingtransactions/README.md)

* [ListAuthorizations](docs/sdks/issuingtransactions/README.md#listauthorizations) - List issued card authorizations associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [GetAuthorization](docs/sdks/issuingtransactions/README.md#getauthorization) - Retrieves details of an authorization associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [ListAuthorizationEvents](docs/sdks/issuingtransactions/README.md#listauthorizationevents) - List card network and Moov platform events that affect the authorization and its hold on a wallet balance.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [List](docs/sdks/issuingtransactions/README.md#list) - List issued card transactions associated with a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.
* [Get](docs/sdks/issuingtransactions/README.md#get) - Retrieves details of an issued card transaction associated with a specific Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/issued-cards.read` scope.

### [Onboarding](docs/sdks/onboarding/README.md)

* [CreateInvite](docs/sdks/onboarding/README.md#createinvite) - Create an invitation containing a unique link that allows the recipient to onboard their organization with Moov.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.
* [ListInvites](docs/sdks/onboarding/README.md#listinvites) - List all the onboarding invites created by the caller's account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.read` scope.
* [GetInvite](docs/sdks/onboarding/README.md#getinvite) - Retrieve details about an onboarding invite.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.read` scope.
* [RevokeInvite](docs/sdks/onboarding/README.md#revokeinvite) - Revoke an onboarding invite, rendering the invitation link unusable.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts.write` scope.

### [PaymentLinks](docs/sdks/paymentlinks/README.md)

* [Create](docs/sdks/paymentlinks/README.md#create) - Create a payment link that allows an end user to make a payment on Moov's hosted payment link page.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [List](docs/sdks/paymentlinks/README.md#list) - List all the payment links created under a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Get](docs/sdks/paymentlinks/README.md#get) - Retrieve a payment link by code.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Update](docs/sdks/paymentlinks/README.md#update) - Update a payment link.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [Disable](docs/sdks/paymentlinks/README.md#disable) - Disable a payment link.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [GetQRCode](docs/sdks/paymentlinks/README.md#getqrcode) - Retrieve the payment link encoded in a QR code. 

Use the `Accept` header to specify the format of the response. Supported formats are `application/json` and `image/png`.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.

### [PaymentMethods](docs/sdks/paymentmethods/README.md)

* [List](docs/sdks/paymentmethods/README.md#list) - Retrieve a list of payment methods associated with a Moov account. Read our [payment methods 
guide](https://docs.moov.io/guides/money-movement/payment-methods/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/payment-methods.read` scope.
* [Get](docs/sdks/paymentmethods/README.md#get) - Get the specified payment method associated with a Moov account. Read our [payment methods guide](https://docs.moov.io/guides/money-movement/payment-methods/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/payment-methods.read` scope.

### [Ping](docs/sdks/ping/README.md)

* [Ping](docs/sdks/ping/README.md#ping) - A simple endpoint to check auth.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/ping.read` scope.

### [Products](docs/sdks/products/README.md)

* [List](docs/sdks/products/README.md#list) - List active (non-disabled) products for an account.
* [Create](docs/sdks/products/README.md#create) - Creates a new product for the specified account.
* [Get](docs/sdks/products/README.md#get) - Retrieve a product by ID.
* [Update](docs/sdks/products/README.md#update) - Update a product and its options.
* [Disable](docs/sdks/products/README.md#disable) - Disable a product by ID.

The product will no longer be available, but will remain in the system for historical and reporting purposes.

### [Receipts](docs/sdks/receipts/README.md)

* [Create](docs/sdks/receipts/README.md#create) -  Create receipts for transfers and scheduled transfers.

 To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
 you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [List](docs/sdks/receipts/README.md#list) - List receipts by transferID, scheduleID, or occurrenceID.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### [Representatives](docs/sdks/representatives/README.md)

* [Create](docs/sdks/representatives/README.md#create) - Moov accounts associated with businesses require information regarding individuals who represent the business. 
You can provide this information by creating a representative. Each account is allowed a maximum of 7 representatives. 
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.
* [List](docs/sdks/representatives/README.md#list) - A Moov account may have multiple representatives depending on the associated business's ownership and management structure. 
You can use this method to list all the representatives for a given Moov account. 
Note that Moov accounts associated with an individual do not have representatives. 
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.read` scope.
* [Delete](docs/sdks/representatives/README.md#delete) - Deletes a business representative associated with a Moov account. Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.
* [Get](docs/sdks/representatives/README.md#get) - Retrieve a specific representative associated with a given Moov account. Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/representatives.read` scope.
* [Update](docs/sdks/representatives/README.md#update) - If a representative's information has changed you can patch the information associated with a specific representative ID.
Read our [business representatives guide](https://docs.moov.io/guides/accounts/requirements/business-representatives/) to learn more.

When **can** profile data be updated:

- For unverified representatives, all profile data can be edited.
- During the verification process, missing or incomplete profile data can be edited.
- Verified representatives can only add missing profile data.

When **can't** profile data be updated:

- Verified representatives cannot change any existing profile data.

If you need to update information in a locked state, please contact Moov support.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/representatives.write` scope.

### [Scheduling](docs/sdks/scheduling/README.md)

* [Create](docs/sdks/scheduling/README.md#create) - Describes the schedule to create or modify.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [List](docs/sdks/scheduling/README.md#list) - Describes a list of schedules associated with an account. Append the `hydrate=accounts` query parameter to include partial account details in the response.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Update](docs/sdks/scheduling/README.md#update) - Describes the schedule to modify.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [Get](docs/sdks/scheduling/README.md#get) - Describes a schedule associated with an account. Requires at least 1 occurrence or recurTransfer to be specified.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Cancel](docs/sdks/scheduling/README.md#cancel) - Describes the schedule to cancel.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [GetOccurrance](docs/sdks/scheduling/README.md#getoccurrance) - Gets a specific occurrence.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.

### [Statements](docs/sdks/statements/README.md)

* [List](docs/sdks/statements/README.md#list) - Retrieve all statements associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [Get](docs/sdks/statements/README.md#get) - Retrieve a statement by its ID.

Use the `Accept` header to specify the format of the response. Supported formats are `application/json` and `application/pdf`.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/profile.read` scope.

### [Support](docs/sdks/support/README.md)

* [CreateTicket](docs/sdks/support/README.md#createticket) - Create a support ticket for a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/tickets.write` scope.

If you're creating the ticket on behalf of another account, then you'll need to
specify the `/accounts/{partnerAccountID}/tickets.write` and `/accounts/{accountID}/profile.read` scopes.
* [ListTickets](docs/sdks/support/README.md#listtickets) - List all the support tickets created under a Moov account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/tickets.read` scope.

If you're listing another account's tickets, then you'll need to
specify the `/accounts/{partnerAccountID}/tickets.read` and `/accounts/{accountID}/profile.read` scopes.
* [GetTicket](docs/sdks/support/README.md#getticket) - Retrieve a support ticket by ID.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/tickets.read` scope.

If you're retrieving another account's ticket, then you'll need to
specify the `/accounts/{partnerAccountID}/tickets.read` and `/accounts/{accountID}/profile.read` scopes.
* [UpdateTicket](docs/sdks/support/README.md#updateticket) - Updates a support ticket.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/tickets.write` scope.

If you're updating the ticket on behalf of another account, then you'll need to
specify the `/accounts/{partnerAccountID}/tickets.write` and `/accounts/{accountID}/profile.read` scopes.
* [ListTicketMessages](docs/sdks/support/README.md#listticketmessages) - List all the messages for a support ticket.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/tickets.read` scope.

If you're listing another account's messages, then you'll need to
specify the `/accounts/{partnerAccountID}/tickets.read` and `/accounts/{accountID}/profile.read` scopes.

### [Sweeps](docs/sdks/sweeps/README.md)

* [CreateConfig](docs/sdks/sweeps/README.md#createconfig) - Create a sweep config for a wallet.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.write` scope.
* [ListConfigs](docs/sdks/sweeps/README.md#listconfigs) - List sweep configs associated with an account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [GetConfig](docs/sdks/sweeps/README.md#getconfig) - Get a sweep config associated with a wallet.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [UpdateConfig](docs/sdks/sweeps/README.md#updateconfig) - Update settings on a sweep config.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/wallets.write` scope.
* [List](docs/sdks/sweeps/README.md#list) - List sweeps associated with a wallet.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Get](docs/sdks/sweeps/README.md#get) - Get details on a specific sweep.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### [TerminalApplications](docs/sdks/terminalapplications/README.md)

* [Create](docs/sdks/terminalapplications/README.md#create) - Create a new terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.
* [List](docs/sdks/terminalapplications/README.md#list) - List all the terminal applications for a Moov Account.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.read` scope.
* [Get](docs/sdks/terminalapplications/README.md#get) - Fetch a specific terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.read` scope.
* [Delete](docs/sdks/terminalapplications/README.md#delete) - Delete a specific terminal application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.
* [CreateVersion](docs/sdks/terminalapplications/README.md#createversion) - Register a new version of a terminal application. For Android applications, this is used to register a new version code of the application.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/terminal-applications.write` scope.

### [Transfers](docs/sdks/transfers/README.md)

* [GenerateOptions](docs/sdks/transfers/README.md#generateoptions) - Generate available payment method options for one or multiple transfer participants depending on the accountID or paymentMethodID you 
supply in the request body.

The accountID in the route should the partner's accountID.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [Create](docs/sdks/transfers/README.md#create) - Move money by providing the source, destination, and amount in the request body.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [List](docs/sdks/transfers/README.md#list) - List all the transfers associated with a particular Moov account. 

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more. 

When you run this request, you retrieve 200 transfers at a time. You can advance past a results set of 200 transfers by using the `skip` parameter (for example, 
if you set `skip`= 10, you will see a results set of 200 transfers after the first 10). If you are searching a high volume of transfers, the request will likely 
process very slowly. To achieve faster performance, restrict the data as much as you can by using the `StartDateTime` and `EndDateTime` parameters for a limited 
period of time. You can run multiple requests in smaller time window increments until you've retrieved all the transfers you need.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Get](docs/sdks/transfers/README.md#get) - Retrieve full transfer details for an individual transfer of a particular Moov account. 

Payment rail-specific details are included in the source and destination. Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) 
to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [Update](docs/sdks/transfers/README.md#update) - Update the metadata contained on a transfer.

Read our [transfers overview guide](https://docs.moov.io/guides/money-movement/overview/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [CreateCancellation](docs/sdks/transfers/README.md#createcancellation) -   Initiate a cancellation for a card, ACH, or queued transfer.
  
  To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
  to specify the `/accounts/{accountID}/transfers.write` scope.
* [GetCancellation](docs/sdks/transfers/README.md#getcancellation) -   Get details of a cancellation for a transfer.
  
  To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
  to specify the `/accounts/{accountID}/transfers.read` scope.
* [InitiateRefund](docs/sdks/transfers/README.md#initiaterefund) - Initiate a refund for a card transfer.

**Use the [Cancel or refund a card transfer](https://docs.moov.io/api/money-movement/refunds/cancel/) endpoint for more comprehensive cancel and refund options.**    
See the [reversals](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/reversals/) guide for more information. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.write` scope.
* [ListRefunds](docs/sdks/transfers/README.md#listrefunds) - Get a list of refunds for a card transfer.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [GetRefund](docs/sdks/transfers/README.md#getrefund) - Get details of a refund for a card transfer.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/transfers.read` scope.
* [CreateReversal](docs/sdks/transfers/README.md#createreversal) - Reverses a card transfer by initiating a cancellation or refund depending on the transaction status. 
Read our [reversals guide](https://docs.moov.io/guides/money-movement/accept-payments/card-acceptance/reversals/) 
to learn more.

To access this endpoint using a [token](https://docs.moov.io/api/authentication/access-tokens/) you'll need 
to specify the `/accounts/{accountID}/transfers.write` scope.

### [Underwriting](docs/sdks/underwriting/README.md)

* [Get](docs/sdks/underwriting/README.md#get) - Retrieve underwriting associated with a given Moov account. 

Read our [underwriting guide](https://docs.moov.io/guides/accounts/requirements/underwriting/) to learn more. 

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.read` scope.
* [Save](docs/sdks/underwriting/README.md#save) - Create or update the account's underwriting.

Read our [underwriting guide](https://docs.moov.io/guides/accounts/requirements/underwriting/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.
* [Upsert](docs/sdks/underwriting/README.md#upsert) - Create or update the account's underwriting.

Read our [underwriting guide](https://docs.moov.io/guides/accounts/requirements/underwriting/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/profile.write` scope.

### [WalletTransactions](docs/sdks/wallettransactions/README.md)

* [List](docs/sdks/wallettransactions/README.md#list) - List all the transactions associated with a particular Moov wallet. 

Read our [wallet transactions guide](https://docs.moov.io/guides/sources/wallets/transactions/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Get](docs/sdks/wallettransactions/README.md#get) - Get details on a specific wallet transaction. 

Read our [wallet transactions guide](https://docs.moov.io/guides/sources/wallets/transactions/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.

### [Wallets](docs/sdks/wallets/README.md)

* [Create](docs/sdks/wallets/README.md#create) - Create a new wallet for an account. You can specify optional attributes such as a display name and description to specify the intended use of the wallet. This will generate a new moov-wallet payment method.

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.write` scope.
* [List](docs/sdks/wallets/README.md#list) - List the wallets associated with a Moov account. 

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Get](docs/sdks/wallets/README.md#get) - Get information on a specific wallet (e.g., the available balance). 

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/) 
you'll need to specify the `/accounts/{accountID}/wallets.read` scope.
* [Update](docs/sdks/wallets/README.md#update) - Update properties of an existing wallet such as name, description, status, or metadata.

Read our [Moov wallets guide](https://docs.moov.io/guides/sources/wallets/) to learn more.

To access this endpoint using an [access token](https://docs.moov.io/api/authentication/access-tokens/)
you'll need to specify the `/accounts/{accountID}/wallets.write` scope.

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`MoovException`](./src/Moov/Sdk/Models/Errors/MoovException.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `Request`     | *HttpRequestMessage*  | HTTP request object   |
| `Response`    | *HttpResponseMessage* | HTTP response object  |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

### Example

```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;
using Moov.Sdk.Models.Errors;

var sdk = new MoovClient(xMoovVersion: "<value>");

try
{
    var res = await sdk.Accounts.CreateAsync(body: new CreateAccount() {
        AccountType = CreateAccountType.Business,
        Profile = new CreateProfile() {
            Business = new CreateBusinessProfile() {
                LegalBusinessName = "Whole Body Fitness LLC",
            },
        },
    });

    // handle response
}
catch (MoovException ex)  // all SDK exceptions inherit from MoovException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpRequestMessage request = ex.Request;
    HttpResponseMessage response = ex.Response;
    var statusCode = (int)response.StatusCode;
    var responseBody = ex.Body;

    if (ex is GenericError) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        GenericErrorPayload payload = ex.Payload;
        string Error = payload.Error;
        HTTPMetadata HttpMeta = payload.HttpMeta;
    }

    // An underlying cause may be provided
    if (ex.InnerException != null)
    {
        Exception cause = ex.InnerException;
    }
}
catch (OperationCanceledException ex)
{
    // CancellationToken was cancelled
}
catch (System.Net.Http.HttpRequestException ex)
{
    // Check ex.InnerException for Network connectivity errors
}
```

### Error Classes

**Primary exception:**
* [`MoovException`](./src/Moov/Sdk/Models/Errors/MoovException.cs): The base class for HTTP error responses.

<details><summary>Less common exceptions (52)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`MoovException`](./src/Moov/Sdk/Models/Errors/MoovException.cs):
  * [`GenericError`](./src/Moov/Sdk/Models/Errors/GenericError.cs): Applicable to 74 of 167 methods.*
  * [`BrandValidationError`](./src/Moov/Sdk/Models/Errors/BrandValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 167 methods.*
  * [`ImageRequestValidationError`](./src/Moov/Sdk/Models/Errors/ImageRequestValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 167 methods.*
  * [`ProductRequestValidationError`](./src/Moov/Sdk/Models/Errors/ProductRequestValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 167 methods.*
  * [`ScheduleValidationError`](./src/Moov/Sdk/Models/Errors/ScheduleValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 167 methods.*
  * [`TerminalApplicationError`](./src/Moov/Sdk/Models/Errors/TerminalApplicationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 167 methods.*
  * [`TransferException`](./src/Moov/Sdk/Models/Errors/TransferException.cs): Details of a Transfer. Status code `409`. Applicable to 1 of 167 methods.*
  * [`CardAcquiringRefundException`](./src/Moov/Sdk/Models/Errors/CardAcquiringRefundException.cs): Details of a card refund. Status code `409`. Applicable to 1 of 167 methods.*
  * [`CreateAccountError`](./src/Moov/Sdk/Models/Errors/CreateAccountError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`PatchAccountError`](./src/Moov/Sdk/Models/Errors/PatchAccountError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`AssignCountriesError`](./src/Moov/Sdk/Models/Errors/AssignCountriesError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`LinkApplePayError`](./src/Moov/Sdk/Models/Errors/LinkApplePayError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`BankAccountValidationError`](./src/Moov/Sdk/Models/Errors/BankAccountValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`MicroDepositValidationError`](./src/Moov/Sdk/Models/Errors/MicroDepositValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`AddCapabilitiesError`](./src/Moov/Sdk/Models/Errors/AddCapabilitiesError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`LinkCardError`](./src/Moov/Sdk/Models/Errors/LinkCardError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`UpdateCardError`](./src/Moov/Sdk/Models/Errors/UpdateCardError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`FileUploadValidationError`](./src/Moov/Sdk/Models/Errors/FileUploadValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`FeePlanAgreementError`](./src/Moov/Sdk/Models/Errors/FeePlanAgreementError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`FileValidationError`](./src/Moov/Sdk/Models/Errors/FileValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`ImageMetadataValidationError`](./src/Moov/Sdk/Models/Errors/ImageMetadataValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`CreateInvoiceError`](./src/Moov/Sdk/Models/Errors/CreateInvoiceError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`ListInvoicesValidationError`](./src/Moov/Sdk/Models/Errors/ListInvoicesValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`UpdateInvoiceError`](./src/Moov/Sdk/Models/Errors/UpdateInvoiceError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`MarkInvoicePaidError`](./src/Moov/Sdk/Models/Errors/MarkInvoicePaidError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`CreatePaymentLinkError`](./src/Moov/Sdk/Models/Errors/CreatePaymentLinkError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`UpdatePaymentLinkError`](./src/Moov/Sdk/Models/Errors/UpdatePaymentLinkError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`RepresentativeValidationError`](./src/Moov/Sdk/Models/Errors/RepresentativeValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`CreateSweepConfigError`](./src/Moov/Sdk/Models/Errors/CreateSweepConfigError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`PatchSweepConfigError`](./src/Moov/Sdk/Models/Errors/PatchSweepConfigError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`AccountTerminalApplicationError`](./src/Moov/Sdk/Models/Errors/AccountTerminalApplicationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`CreateTicketError`](./src/Moov/Sdk/Models/Errors/CreateTicketError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`UpdateTicketError`](./src/Moov/Sdk/Models/Errors/UpdateTicketError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`TransferOptionsValidationError`](./src/Moov/Sdk/Models/Errors/TransferOptionsValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`TransferValidationError`](./src/Moov/Sdk/Models/Errors/TransferValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`ListTransfersValidationError`](./src/Moov/Sdk/Models/Errors/ListTransfersValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`PatchTransferValidationError`](./src/Moov/Sdk/Models/Errors/PatchTransferValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`RefundValidationError`](./src/Moov/Sdk/Models/Errors/RefundValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`ReversalValidationError`](./src/Moov/Sdk/Models/Errors/ReversalValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`UpsertUnderwritingError`](./src/Moov/Sdk/Models/Errors/UpsertUnderwritingError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`UpdateUnderwritingError`](./src/Moov/Sdk/Models/Errors/UpdateUnderwritingError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`CreateWalletValidationError`](./src/Moov/Sdk/Models/Errors/CreateWalletValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`ListWalletsValidationError`](./src/Moov/Sdk/Models/Errors/ListWalletsValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`PatchWalletValidationError`](./src/Moov/Sdk/Models/Errors/PatchWalletValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`ListWalletTransactionsValidationError`](./src/Moov/Sdk/Models/Errors/ListWalletTransactionsValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`RequestCardError`](./src/Moov/Sdk/Models/Errors/RequestCardError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`UpdateIssuedCardError`](./src/Moov/Sdk/Models/Errors/UpdateIssuedCardError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`RevokeTokenRequestError`](./src/Moov/Sdk/Models/Errors/RevokeTokenRequestError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`AuthTokenRequestError`](./src/Moov/Sdk/Models/Errors/AuthTokenRequestError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`OnboardingInviteError`](./src/Moov/Sdk/Models/Errors/OnboardingInviteError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 167 methods.*
  * [`ResponseValidationError`](./src/Moov/Sdk/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(
    serverUrl: "https://api.moov.io",
    xMoovVersion: "<value>"
);

var res = await sdk.Accounts.CreateAsync(body: new CreateAccount() {
    AccountType = CreateAccountType.Business,
    Profile = new CreateProfile() {
        Business = new CreateBusinessProfile() {
            LegalBusinessName = "Whole Body Fitness LLC",
        },
    },
});

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The C# SDK makes API calls using an `ISpeakeasyHttpClient` that wraps the native
[HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient). This
client provides the ability to attach hooks around the request lifecycle that can be used to modify the request or handle
errors and response.

The `ISpeakeasyHttpClient` interface allows you to either use the default `SpeakeasyHttpClient` that comes with the SDK,
or provide your own custom implementation with customized configuration such as custom message handlers, timeouts,
connection pooling, and other HTTP client settings.

The following example shows how to create a custom HTTP client with request modification and error handling:

```csharp
using Moov.Sdk;
using Moov.Sdk.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Create a custom HTTP client
public class CustomHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _defaultClient;

    public CustomHttpClient()
    {
        _defaultClient = new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Add custom header and timeout
        request.Headers.Add("x-custom-header", "custom value");
        request.Headers.Add("x-request-timeout", "30");
        
        try
        {
            var response = await _defaultClient.SendAsync(request, cancellationToken);
            // Log successful response
            Console.WriteLine($"Request successful: {response.StatusCode}");
            return response;
        }
        catch (Exception error)
        {
            // Log error
            Console.WriteLine($"Request failed: {error.Message}");
            throw;
        }
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
        _defaultClient?.Dispose();
    }
}

// Use the custom HTTP client with the SDK
var customHttpClient = new CustomHttpClient();
var sdk = new MoovClient(client: customHttpClient);
```

<details>
<summary>You can also provide a completely custom HTTP client with your own configuration:</summary>

```csharp
using Moov.Sdk.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Custom HTTP client with custom configuration
public class AdvancedHttpClient : ISpeakeasyHttpClient
{
    private readonly HttpClient _httpClient;

    public AdvancedHttpClient()
    {
        var handler = new HttpClientHandler()
        {
            MaxConnectionsPerServer = 10,
            // ServerCertificateCustomValidationCallback = customCertValidation, // Custom SSL validation if needed
        };

        _httpClient = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        return await _httpClient.SendAsync(request, cancellationToken ?? CancellationToken.None);
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}

var sdk = MoovClient.Builder()
    .WithClient(new AdvancedHttpClient())
    .Build();
```
</details>

<details>
<summary>For simple debugging, you can enable request/response logging by implementing a custom client:</summary>

```csharp
public class LoggingHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _innerClient;

    public LoggingHttpClient(ISpeakeasyHttpClient innerClient = null)
    {
        _innerClient = innerClient ?? new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Log request
        Console.WriteLine($"Sending {request.Method} request to {request.RequestUri}");
        
        var response = await _innerClient.SendAsync(request, cancellationToken);
        
        // Log response
        Console.WriteLine($"Received {response.StatusCode} response");
        
        return response;
    }

    public void Dispose() => _innerClient?.Dispose();
}

var sdk = new MoovClient(client: new LoggingHttpClient());
```
</details>

The SDK also provides built-in hook support through the `SDKConfiguration.Hooks` system, which automatically handles
`BeforeRequestAsync`, `AfterSuccessAsync`, and `AfterErrorAsync` hooks for advanced request lifecycle management.
<!-- End Custom HTTP Client [http-client] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=moov-sdk&utm_campaign=csharp)
