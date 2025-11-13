# Moov


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

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

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                      | Type | Scheme     |
| ------------------------- | ---- | ---------- |
| `Username`<br/>`Password` | http | HTTP Basic |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using Moov;
using Moov.Models.Components;

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

<!-- Start Error Handling [errors] -->
## Error Handling

[`MoovException`](./src/Moov/Models/Errors/MoovException.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `Request`     | *HttpRequestMessage*  | HTTP request object   |
| `Response`    | *HttpResponseMessage* | HTTP response object  |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

### Example

```csharp
using Moov;
using Moov.Models.Components;
using Moov.Models.Errors;

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
* [`MoovException`](./src/Moov/Models/Errors/MoovException.cs): The base class for HTTP error responses.

<details><summary>Less common exceptions (48)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`MoovException`](./src/Moov/Models/Errors/MoovException.cs):
  * [`GenericError`](./src/Moov/Models/Errors/GenericError.cs): Applicable to 72 of 162 methods.*
  * [`BrandValidationError`](./src/Moov/Models/Errors/BrandValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 3 of 162 methods.*
  * [`ImageRequestValidationError`](./src/Moov/Models/Errors/ImageRequestValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 162 methods.*
  * [`ProductRequestValidationError`](./src/Moov/Models/Errors/ProductRequestValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 162 methods.*
  * [`ScheduleValidationError`](./src/Moov/Models/Errors/ScheduleValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 162 methods.*
  * [`TerminalApplicationError`](./src/Moov/Models/Errors/TerminalApplicationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 2 of 162 methods.*
  * [`TransferException`](./src/Moov/Models/Errors/TransferException.cs): Details of a Transfer. Status code `409`. Applicable to 1 of 162 methods.*
  * [`CardAcquiringRefundException`](./src/Moov/Models/Errors/CardAcquiringRefundException.cs): Details of a card refund. Status code `409`. Applicable to 1 of 162 methods.*
  * [`CreateAccountError`](./src/Moov/Models/Errors/CreateAccountError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`PatchAccountError`](./src/Moov/Models/Errors/PatchAccountError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`AssignCountriesError`](./src/Moov/Models/Errors/AssignCountriesError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`LinkApplePayError`](./src/Moov/Models/Errors/LinkApplePayError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`BankAccountValidationError`](./src/Moov/Models/Errors/BankAccountValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`MicroDepositValidationError`](./src/Moov/Models/Errors/MicroDepositValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`AddCapabilitiesError`](./src/Moov/Models/Errors/AddCapabilitiesError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`LinkCardError`](./src/Moov/Models/Errors/LinkCardError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`UpdateCardError`](./src/Moov/Models/Errors/UpdateCardError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`FileUploadValidationError`](./src/Moov/Models/Errors/FileUploadValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`FeePlanAgreementError`](./src/Moov/Models/Errors/FeePlanAgreementError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`FileValidationError`](./src/Moov/Models/Errors/FileValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`ImageMetadataValidationError`](./src/Moov/Models/Errors/ImageMetadataValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`CreatePaymentLinkError`](./src/Moov/Models/Errors/CreatePaymentLinkError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`UpdatePaymentLinkError`](./src/Moov/Models/Errors/UpdatePaymentLinkError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`RepresentativeValidationError`](./src/Moov/Models/Errors/RepresentativeValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`CreateSweepConfigError`](./src/Moov/Models/Errors/CreateSweepConfigError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`PatchSweepConfigError`](./src/Moov/Models/Errors/PatchSweepConfigError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`AccountTerminalApplicationError`](./src/Moov/Models/Errors/AccountTerminalApplicationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`CreateTicketError`](./src/Moov/Models/Errors/CreateTicketError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`UpdateTicketError`](./src/Moov/Models/Errors/UpdateTicketError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`TransferOptionsValidationError`](./src/Moov/Models/Errors/TransferOptionsValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`TransferValidationError`](./src/Moov/Models/Errors/TransferValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`ListTransfersValidationError`](./src/Moov/Models/Errors/ListTransfersValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`PatchTransferValidationError`](./src/Moov/Models/Errors/PatchTransferValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`RefundValidationError`](./src/Moov/Models/Errors/RefundValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`ReversalValidationError`](./src/Moov/Models/Errors/ReversalValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`UpsertUnderwritingError`](./src/Moov/Models/Errors/UpsertUnderwritingError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`UpdateUnderwritingError`](./src/Moov/Models/Errors/UpdateUnderwritingError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`CreateWalletValidationError`](./src/Moov/Models/Errors/CreateWalletValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`ListWalletsValidationError`](./src/Moov/Models/Errors/ListWalletsValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`PatchWalletValidationError`](./src/Moov/Models/Errors/PatchWalletValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`ListWalletTransactionsValidationError`](./src/Moov/Models/Errors/ListWalletTransactionsValidationError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`RequestCardError`](./src/Moov/Models/Errors/RequestCardError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`UpdateIssuedCardError`](./src/Moov/Models/Errors/UpdateIssuedCardError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`RevokeTokenRequestError`](./src/Moov/Models/Errors/RevokeTokenRequestError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`AuthTokenRequestError`](./src/Moov/Models/Errors/AuthTokenRequestError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`OnboardingInviteError`](./src/Moov/Models/Errors/OnboardingInviteError.cs): The request was well-formed, but the contents failed validation. Check the request for missing or invalid fields. Status code `422`. Applicable to 1 of 162 methods.*
  * [`ResponseValidationError`](./src/Moov/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Moov;
using Moov.Models.Components;

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
using Moov;
using Moov.Utils;
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
using Moov.Utils;
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