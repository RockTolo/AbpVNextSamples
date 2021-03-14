using Volo.Abp.Settings;

namespace Tolo.Abp.ElsaCore.Settings
{
    public class ElsaCoreSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ElsaCoreSettings.MySetting1));
        }
    }
}
