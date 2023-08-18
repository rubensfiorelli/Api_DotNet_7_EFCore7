using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSummit.Core.Entities;

namespace ProSummit.Data.Mapping
{
    public class SpeakerMap : IEntityTypeConfiguration<SummitSpeaker>
    {
        public void Configure(EntityTypeBuilder<SummitSpeaker> builder)
        {
            builder
                .HasKey(key => key.Id);

            builder
                .Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(p => p.TalkTitle)
               .HasMaxLength(300)
               .IsRequired();

            builder
               .Property(p => p.Description)
               .HasMaxLength(600)
               .IsRequired();

            builder
               .Property(p => p.Linkedin)
               .HasMaxLength(50)
               .IsRequired();

            builder
               .HasOne(p => p.Event)
               .WithMany(p => p.Speakers);
        }
    }
}
