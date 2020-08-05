using Volo.Abp.Settings;

namespace AKH.Portfolio.Settings
{
    public class PortfolioSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PortfolioSettings.MySetting1));
        }
    }
}
