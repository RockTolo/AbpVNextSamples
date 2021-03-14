using Tolo.Abp.ElsaCore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Tolo.Abp.ElsaCore.Permissions
{
    public class ElsaCorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ElsaCorePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ElsaCorePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ElsaCoreResource>(name);
        }
    }
}
