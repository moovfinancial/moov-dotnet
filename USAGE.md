<!-- Start SDK Example Usage [usage] -->
```csharp
using Moov.Sdk;
using Moov.Sdk.Models.Components;

var sdk = new MoovClient(security: new Security() {
    Username = "",
    Password = "",
});

CreateAccount req = new CreateAccount() {
    AccountType = CreateAccountType.Business,
    Profile = new CreateProfile() {
        Business = new CreateBusinessProfile() {
            LegalBusinessName = "Whole Body Fitness LLC",
        },
    },
};

var res = await sdk.Accounts.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->