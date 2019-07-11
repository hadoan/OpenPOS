using System.Threading.Tasks;
using OpenPOS.Users.Configuration.Dto;

namespace OpenPOS.Users.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
