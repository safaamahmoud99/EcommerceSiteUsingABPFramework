using Volo.Abp.Settings;

namespace EcommerceSite.Settings
{
    public class EcommerceSiteSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(EcommerceSiteSettings.MySetting1));
        }
    }
}
