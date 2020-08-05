using AKH.Portfolio.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AKH.Portfolio.Permissions
{
    public class PortfolioPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(PortfolioPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(PortfolioPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PortfolioResource>(name);
        }
    }
}
