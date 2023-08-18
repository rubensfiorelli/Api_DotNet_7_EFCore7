using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSummit.Core.Entities;

namespace ProSummit.Data.Mapping
{
    public class BatchMap : IEntityTypeConfiguration<SummitBatch>
    {
        public void Configure(EntityTypeBuilder<SummitBatch> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(b => b.Title)
                .HasMaxLength(60)
                .IsRequired();

            builder
                .Property(b => b.Title)
                .HasMaxLength(60)
                .IsRequired();

            builder
                 .Property(b => b.PriceInPerson)
                 .HasColumnType("float(10,2)");

            builder
                .Property(b => b.PriceOnLine)
                .HasColumnType("float(10,2)");

            builder
               .HasOne(p => p.SummitEvent)
               .WithMany()
               .HasForeignKey(p => p.SummitEventId);



        }
    }
}
