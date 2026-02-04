<!-- Start SDK Example Usage [usage] -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(xMoovVersion: "<value>");

var res = await sdk.Accounts.CreateAsync(body: new CreateAccount() {
    AccountType = AccountType.Business,
    Profile = new CreateProfile() {
        Business = new CreateBusinessProfile() {
            LegalBusinessName = "Whole Body Fitness LLC",
        },
    },
});

// handle response
```
<!-- End SDK Example Usage [usage] -->