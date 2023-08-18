using ProSummit.Core.Entities;

namespace ProSummit.Core.Interfaces.Repositories
{
    public interface IWriteSummitEventRepository : IUnitOfWork
    {
        Task AddAsync(SummitEvent summitEvent);
        Task Update(SummitEvent summitEvent);
        Task<bool> Delete(Guid id);

    }
}
