using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSummit.Core.Entities.TicketsContext;

namespace ProSummit.Data.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<SummitCustomer>
    {
        public void Configure(EntityTypeBuilder<SummitCustomer> builder)
        {
            builder
                .OwnsOne(n => n.Address);

        }
    }
}
