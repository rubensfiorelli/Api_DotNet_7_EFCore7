using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSummit.Core.Entities;

namespace ProSummit.Data.Mapping
{
    public class SummitEventMap : IEntityTypeConfiguration<SummitEvent>
    {
        public void Configure(EntityTypeBuilder<SummitEvent> builder)
        {
            builder
                .HasKey(key => key.Id);

            builder
                .Property(p => p.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(p => p.Description)
               .HasMaxLength(300)
               .IsRequired();

            builder
              .Property(p => p.Place)
              .HasMaxLength(60)
              .IsRequired();

            builder
              .Property(p => p.ImgUrl)
              .HasMaxLength(150)
              .IsRequired();

            builder
             .Property(p => p.WebSite)
             .HasMaxLength(100)
             .IsRequired();

            builder
               .HasMany(p => p.Speakers)
               .WithOne(p => p.Event)
               .HasForeignKey(p => p.SummitEventId);

            builder
               .HasMany(p => p.Batches)
               .WithOne(p => p.SummitEvent)
               .HasForeignKey(p => p.SummitEventId);
        }
    }
}
