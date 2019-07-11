using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OpenPOS.Users.Configuration.Dto;

namespace OpenPOS.Users.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : UsersAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
