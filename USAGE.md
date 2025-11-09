<!-- Start SDK Example Usage [usage] -->
```csharp
using Moov;
using Moov.Models.Components;

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