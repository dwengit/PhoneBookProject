using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBookProject.Sessions.Dto;

namespace PhoneBookProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
