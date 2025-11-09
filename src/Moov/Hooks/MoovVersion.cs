namespace Moov.Hooks
{
    public class MoovVersion : ISDKInitHook
    {
        public SDKConfig SDKInit(SDKConfig config)
        {
            config.XMoovVersion = "latest";
            return config;
        }
    }
}