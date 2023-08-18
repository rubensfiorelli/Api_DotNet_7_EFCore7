using ProSummit.Core.Entities.TicketsContext;

namespace ProSummit.Core.Interfaces.Repositories
{
    public interface ISummitOrderRepository : IUnitOfWork
    {
        Task<SummitOrder> GetSummitOrderAsync(Guid id);
        Task AddAsync(SummitOrder order);
    }
}
