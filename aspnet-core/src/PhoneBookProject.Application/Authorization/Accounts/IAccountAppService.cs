using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBookProject.Authorization.Accounts.Dto;

namespace PhoneBookProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
