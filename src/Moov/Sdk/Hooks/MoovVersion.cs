namespace Moov.Sdk.Hooks
{
    using Moov.Sdk.Utils;

    public class MoovVersion : ISDKInitHook
    {
        public SDKConfig SDKInit(SDKConfig config)
        {
            config.XMoovVersion = Constants.OpenApiDocVersion;
            return config;
        }
    }
}
