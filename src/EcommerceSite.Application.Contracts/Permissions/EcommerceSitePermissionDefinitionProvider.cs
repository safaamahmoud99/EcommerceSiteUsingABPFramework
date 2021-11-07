using EcommerceSite.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EcommerceSite.Permissions
{
    public class EcommerceSitePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(EcommerceSitePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(EcommerceSitePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<EcommerceSiteResource>(name);
        }
    }
}
