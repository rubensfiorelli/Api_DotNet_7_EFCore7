using Microsoft.EntityFrameworkCore;
using ProSummit.Core.Entities;
using ProSummit.Core.Interfaces.Repositories;
using ProSummit.Data.Config;

namespace ProSummit.Data.RepositoriesImplemented.SummitEvents
{
    public class WriteSummitEventRepository : IWriteSummitEventRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<SummitEvent> _dataset;

        public WriteSummitEventRepository(ApplicationDbContext context)
        {
            _context = context;
            _dataset = context.Set<SummitEvent>();
        }

        public async Task AddAsync(SummitEvent summitEvent)
        {
            try
            {
                summitEvent.CreateAt = DateTime.UtcNow;
                await _dataset.AddAsync(summitEvent);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Update(SummitEvent newInput)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(se => se.Id.Equals(newInput.Id));
                if (result != null)
                {
                    newInput.UpdateAt = DateTime.UtcNow;
                    newInput.CreateAt = result.CreateAt;

                    result.Update(newInput.Title, newInput.Description, newInput.Place, newInput.StartDate, newInput.EndDate, newInput.Quantity, newInput.ImgUrl, newInput.WebSite);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(se => se.Id.Equals(id));
                result?.Delete();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return true;
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }


    }
}
