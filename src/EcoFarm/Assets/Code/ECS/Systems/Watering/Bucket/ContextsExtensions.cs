namespace EcoFarm
{
    public static class ContextsExtensions
    {
        public static IConfigurationService GetConfiguration(this Contexts @this)
            => @this.services.configurationService.Value;
    }
}