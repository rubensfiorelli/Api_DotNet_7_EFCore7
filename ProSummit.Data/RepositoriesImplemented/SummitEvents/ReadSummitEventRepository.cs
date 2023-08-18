using Microsoft.EntityFrameworkCore;
using ProSummit.Core.Entities;
using ProSummit.Core.Interfaces.Repositories;
using ProSummit.Data.Config;

namespace ProSummit.Data.RepositoriesImplemented.SummitEvents
{
    public class ReadSummitEventRepository : IReadSummitEventRepository
    {
        protected readonly ApplicationDbContext _context;

        public ReadSummitEventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SummitEvent>> GetAllAsync(bool includeSummitSpeaker = true)
        {
            IQueryable<SummitEvent> events = _context.Events
                .Include(se => se.Batches)
                .Include(se => se.Speakers)
                .Take(50)
                .AsNoTracking();

            return await events.ToListAsync();

        }

        public async Task<SummitEvent> GetByIdAsync(Guid id)
        {
            IQueryable<SummitEvent> events = _context.Events
                 .Include(se => se.Batches)
                 .Include(se => se.Speakers)
                 .Where(se => se.Id.Equals(id))
                 .AsNoTracking();


            return await events.FirstOrDefaultAsync();
        }

        public async Task<List<SummitEvent>> GetByTitleAsync(string title, bool includeSummitSpeaker = true)
        {
            IQueryable<SummitEvent> events = _context.Events
                .Include(se => se.Batches)
                .Include(se => se.Speakers)
                .Where(se => se.Title.Normalize().Contains(title.Normalize()))
                .AsNoTracking();


            return await events.ToListAsync();
        }
    }
}
