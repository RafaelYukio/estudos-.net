using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories;
using MVCCleanArchitecture.Domain.Interfaces.Services;
using MVCCleanArchitecture.Domain.Services.Base;

namespace MVCCleanArchitecture.Domain.Services
{
    public class StatusService(IStatusRepository statusRepository) : BaseService<Status>(statusRepository), IStatusService
    {
    }
}
