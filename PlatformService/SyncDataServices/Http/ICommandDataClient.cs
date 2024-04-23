using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatforService.SyncDataService.Http
{

    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
         
    }
}