using ProSummit.Core.Entities.TicketsContext;

namespace ProSummit.Core.Interfaces.Repositories
{
    public interface ISummitCatalogRepository : IUnitOfWork
    {
        Task<List<SummitCatalog>> GetAllAsync();
    }
}
