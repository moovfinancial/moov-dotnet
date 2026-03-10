namespace Moov.Sdk.Hooks
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Moov.Sdk.Utils;

    public class MoovVersion : IBeforeRequestHook
    {
        public Task<HttpRequestMessage> BeforeRequestAsync(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            request.Headers.Remove("X-Moov-Version");
            request.Headers.Add("X-Moov-Version", Constants.OpenApiDocVersion);
            return Task.FromResult(request);
        }
    }
}
