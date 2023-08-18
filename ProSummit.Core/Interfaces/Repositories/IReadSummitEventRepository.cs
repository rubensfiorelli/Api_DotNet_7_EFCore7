using ProSummit.Core.Entities;

namespace ProSummit.Core.Interfaces.Repositories
{
    public interface IReadSummitEventRepository
    {
        Task<List<SummitEvent>> GetAllAsync(bool includeSummitSpeaker = true);
        Task<List<SummitEvent>> GetByTitleAsync(string title, bool includeSummitSpeaker = true);
        Task<SummitEvent> GetByIdAsync(Guid id);
    }
}
